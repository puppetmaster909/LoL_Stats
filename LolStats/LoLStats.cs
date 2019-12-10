using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.SummonerV4;
using MingweiSamuel.Camille.MatchV4;
using MingweiSamuel.Camille.LeagueV4;
using MingweiSamuel.Camille.Enums;
using Newtonsoft.Json;
using System.Net.Http;
using System.Web;
using System.Windows.Forms;

namespace LolStats
{
    public partial class LoLStatsMain : Form
    {
        #region Runtime Values

        private string ApiKey = "";
        private static readonly Uri SummonerByNameBaseAddress = new Uri("https://na1.api.riotgames.com/lol/summoner/v4/summoners");

        private static RiotApi Riot;
        private static List<SummonerData> DataList;

        private bool StatsByLeague = true;


        #endregion

        public LoLStatsMain()
        {
            InitializeComponent();
            
            this.Text = "LoL Stats";

            Riot = RiotApi.NewInstance(ApiKey);
            DataList = new List<SummonerData>();
        }
        
        #region Input

        private void statsByLeagueButton_CheckedChanged(object sender, EventArgs e)
        {
            leagueBox.Enabled = true;
            divisionBox.Enabled = true;
            summonerNameBox.Enabled = false;

            leagueBox.SelectedIndex = 0;
            divisionBox.SelectedIndex = 0;
            summonerNameBox.Text = "";

            StatsByLeague = true;
        }

        private void statsBySummonerButton_CheckedChanged(object sender, EventArgs e)
        {
            leagueBox.Enabled = false;
            divisionBox.Enabled = false;
            summonerNameBox.Enabled = true;

            leagueBox.Text = "";
            divisionBox.Text = "";

            StatsByLeague = false;
        }

        private void regionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StatsByLeague)
            {
                if (IsValidEntry(regionBox, regionBox.Text)
                    && IsValidEntry(leagueBox, leagueBox.Text)
                    && IsValidEntry(divisionBox, divisionBox.Text)
                    && APIKeyBox.TextLength != 0)
                {
                    searchButton.Enabled = true;
                }
                else
                {
                    searchButton.Enabled = false;
                }
            }
            else
            {
                if (IsValidEntry(regionBox, regionBox.Text)
                    && summonerNameBox.Text.Length != 0
                    && APIKeyBox.TextLength != 0)
                {
                    searchButton.Enabled = true;
                }
                else
                {
                    searchButton.Enabled = false;
                }
            }
        }

        private void summonerNameBox_TextChanged(object sender, EventArgs e)
        {
            if (IsValidEntry(regionBox, regionBox.Text)
                && summonerNameBox.Text.Length != 0)
            {
                searchButton.Enabled = true;
            }
            else
            {
                searchButton.Enabled = false;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Riot = RiotApi.NewInstance(ApiKey);

            if (StatsByLeague)
            {
                GetLeagueByDivisionSync(regionBox, divisionBox, leagueBox, top10Summoners);

                Role Top = new Role();
                Top.RoleName = "Top";
                Role Jungle = new Role();
                Jungle.RoleName = "Jungle";
                Role Mid = new Role();
                Mid.RoleName = "Mid";
                Role Support = new Role();
                Support.RoleName = "Support";
                Role ADC = new Role();
                ADC.RoleName = "ADC";

                foreach (SummonerData current in DataList)
                {
                    CalculateTopChampsSync(top10Summoners, current, Top, Jungle, Mid, Support, ADC);
                }

                PopulateTopChampsSync(Top, Jungle, Mid, Support, ADC);

                SummonerData Collective = new SummonerData();
                Collective.Roles.Clear();
                Collective.Roles.Add(Top);
                Collective.Roles.Add(Jungle);
                Collective.Roles.Add(Mid);
                Collective.Roles.Add(Support);
                Collective.Roles.Add(ADC);
                Collective.Name = "Collective";

                PopulatePopularDataSync(Collective);
            }
            else
            {
                if (CheckResponse(regionBox, summonerNameBox.Text, Riot, ApiKey))
                {
                    GetSummonerSync(regionBox, summonerNameBox.Text);

                    GetRoleInfoSync(regionBox, DataList[0]);

                    CalculateTopChampsSync(top10Summoners, DataList[0]);

                    PopulatePopularDataSync(DataList[0]);
                }
                else
                {
                    // Invalid response from server
                    progressBarStatusLabel1.BackColor = Color.FromName("Crimson");
                    progressBarStatusLabel1.Text = "No Response";
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void APIKeyBox_TextChanged(object sender, EventArgs e)
        {
            if (APIKeyBox.TextLength != 0
                && IsValidEntry(leagueBox, leagueBox.Text)
                && IsValidEntry(divisionBox, divisionBox.Text)
                && IsValidEntry(regionBox, regionBox.Text))
            {
                searchButton.Enabled = true;
            }
            else if (APIKeyBox.TextLength != 0
                && IsValidEntry(regionBox, regionBox.Text)
                && summonerNameBox.TextLength != 0)
            {
                searchButton.Enabled = true;
            }
            else
            {
                searchButton.Enabled = false;
            }

            ApiKey = APIKeyBox.Text;
        }

        private void leagueBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void divisionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (APIKeyBox.TextLength != 0
            //    && IsValidEntry(leagueBox, leagueBox.Text)
            //    && IsValidEntry(divisionBox, divisionBox.Text)
            //    && IsValidEntry(regionBox, regionBox.Text))
            //{
            //    searchButton.Enabled = true;
            //}
            //else if (APIKeyBox.TextLength != 0
            //    && IsValidEntry(regionBox, regionBox.Text)
            //    && summonerNameBox.TextLength != 0)
            //{
            //    searchButton.Enabled = true;
            //}
            //else
            //{
            //    searchButton.Enabled = false;
            //}
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DataList.Clear();
            top10Summoners.Items.Clear();

            progressBarStatusLabel1.BackColor = Color.FromName("Control");
            progressBarStatusLabel1.Text = "";

            topChamp1.Clear();
            topChamp2.Clear();

            jungleChamp1.Clear();
            jungleChamp2.Clear();

            midChamp1.Clear();
            midChamp2.Clear();

            supportChamp1.Clear();
            supportChamp2.Clear();

            carryChamp1.Clear();
            carryChamp2.Clear();

            commonLaneBox.Clear();
            commonRoleBox.Clear();

            averageCSBox.Clear();
            averageGoldBox.Clear();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //JsonSerializer serializer = new JsonSerializer();
            //string output = JsonConvert.SerializeObject(DataList);

            saveFileDialog1.FileName = "LolStats.json";
            saveFileDialog1.Filter = "|*.json";

            if (saveFileDialog1.FileName != "" && saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                JsonSerializer serializer = new JsonSerializer
                {
                    Formatting = Formatting.Indented
                };

                using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(saveFileDialog1.FileName))
                using (JsonWriter jsonWriter = new JsonTextWriter(streamWriter))
                {
                    serializer.Serialize(jsonWriter, DataList);
                }
            }

        }

        #endregion

        // Checks that summoner name is valid by checking for a response from the server
        public static bool CheckResponse(ComboBox region, string name, RiotApi riot, string ApiKey)
        {
            bool gotResponse = false;

            HttpClient client = new HttpClient
            {
                BaseAddress = SummonerByNameBaseAddress
            };

            var uriBuilder = new UriBuilder($"https://{region.Text.ToString()}.api.riotgames.com/lol/summoner/v4/summoners/by-name/{name}");
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["api_key"] = ApiKey;
            uriBuilder.Query = query.ToString();
            string requestUri = uriBuilder.ToString();

            var response = client.GetAsync(requestUri).Result;
            if (response.IsSuccessStatusCode == false)
            {
                gotResponse = false;
            }
            else
            {
                gotResponse = true;
            }

            return gotResponse;
        }

        // Returns true if box contains entry
        private bool IsValidEntry(ComboBox box, string entry)
        {
            foreach (string s in box.Items)
            {
                if (s == entry)
                {
                    return true;
                }
            }

            return false;
        }

        private static void FindTopChamps(Role input)
        {
            Champion topChamp = 0;
            int topChampCount = 0;
            Champion secondChamp = 0;
            int secondChampCount = 0;

            foreach (Champion c in input.ChampionMap.Keys)
            {
                if (input.ChampionMap[c] >= secondChampCount)
                {
                    secondChamp = c;
                    secondChampCount = input.ChampionMap[c];
                }
                if (input.ChampionMap[c] >= topChampCount)
                {
                    secondChamp = topChamp;
                    secondChampCount = topChampCount;
                    topChamp = c;
                    topChampCount = input.ChampionMap[c];

                }
            }

            input.TopChamp = topChamp;
            input.SecondChamp = secondChamp;

            //return input;
        }

        private static void GetSummonerSync(ComboBox region, string name)
        {
            Summoner summoner;
            summoner = Riot.SummonerV4.GetBySummonerName(Utility.GetRegion(region.Text), name);

            SummonerData currentData = new SummonerData();
            currentData.Name = summoner.Name;
            currentData.AccountId = summoner.AccountId;

            DataList.Add(currentData);
        }

        private static void GetRoleInfoSync(ComboBox region, SummonerData current)
        {
            Matchlist matchlist;
            matchlist = Riot.MatchV4.GetMatchlist(Utility.GetRegion(region.Text), current.AccountId);
            
            foreach (MatchReference m in matchlist.Matches)
            {
                switch (m.Lane)
                {
                    case "TOP":
                        current.Roles[0].MatchCount++;
                        if (current.Roles[0].ChampionMap.ContainsKey(m.Champion))
                        {
                            current.Roles[0].ChampionMap[m.Champion]++;
                        }
                        else
                        {
                            current.Roles[0].ChampionMap.Add(m.Champion, 1);
                        }
                        break;

                    case "JUNGLE":
                        current.Roles[1].MatchCount++;
                        if (current.Roles[1].ChampionMap.ContainsKey(m.Champion))
                        {
                            current.Roles[1].ChampionMap[m.Champion]++;
                        }
                        else
                        {
                            current.Roles[1].ChampionMap.Add(m.Champion, 1);
                        }
                        break;

                    case "MID":
                        current.Roles[2].MatchCount++;
                        if (current.Roles[2].ChampionMap.ContainsKey(m.Champion))
                        {
                            current.Roles[2].ChampionMap[m.Champion]++;
                        }
                        else
                        {
                            current.Roles[2].ChampionMap.Add(m.Champion, 1);
                        }
                        break;

                    case "BOTTOM":
                        if (m.Role.Contains("CARRY"))
                        {
                            current.Roles[4].MatchCount++;
                            if (current.Roles[4].ChampionMap.ContainsKey(m.Champion))
                            {
                                current.Roles[4].ChampionMap[m.Champion]++;
                            }
                            else
                            {
                                current.Roles[4].ChampionMap.Add(m.Champion, 1);
                            }
                        }
                        else
                        {
                            current.Roles[3].MatchCount++;
                            if (current.Roles[3].ChampionMap.ContainsKey(m.Champion))
                            {
                                current.Roles[3].ChampionMap[m.Champion]++;
                            }
                            else
                            {
                                current.Roles[3].ChampionMap.Add(m.Champion, 1);
                            }
                        }
                        break;

                    default:
                        if (m.Lane.Equals("NONE"))
                        {
                            if (m.Role.Contains("SUPPORT"))
                            {
                                current.Roles[3].MatchCount++;
                                if (current.Roles[3].ChampionMap.ContainsKey(m.Champion))
                                {
                                    current.Roles[3].ChampionMap[m.Champion]++;
                                }
                                else
                                {
                                    current.Roles[3].ChampionMap.Add(m.Champion, 1);
                                }
                            }
                            else if (m.Role.Equals("DUO"))
                            {
                                break;
                            }
                            else if (m.Role.Contains("CARRY"))
                            {
                                current.Roles[4].MatchCount++;
                                if (current.Roles[4].ChampionMap.ContainsKey(m.Champion))
                                {
                                    current.Roles[4].ChampionMap[m.Champion]++;
                                }
                                else
                                {
                                    current.Roles[4].ChampionMap.Add(m.Champion, 1);
                                }
                            }
                        }
                        break;
                }
            }
        }

        private void CalculateTopChampsSync(ListBox listBox, SummonerData current)
        {
            listBox.Items.Add(current.Name);

            foreach (Role r in current.Roles)
            {
                FindTopChamps(r);
                PopulateTopChampsSync(r);
            }
        }

        private void CalculateTopChampsSync(ListBox listBox, SummonerData current, Role Top, Role Jungle, Role Mid, Role Support, Role ADC)
        {
            listBox.Items.Add(current.Name);

            foreach (Role r in current.Roles)
            {
                switch (r.RoleName)
                {
                    case "Top":
                        CombineRoles(r, Top);

                        break;

                    case "Jungle":
                        CombineRoles(r, Jungle);
                        break;

                    case "Mid":
                        CombineRoles(r, Mid);
                        break;

                    case "Support":
                        CombineRoles(r, Support);
                        break;

                    case "ADC":
                        CombineRoles(r, ADC);
                        break;

                    default:

                        break;
                }
            }

            FindTopChamps(Top);
            PopulateTopChampsSync(Top);

            FindTopChamps(Jungle);
            PopulateTopChampsSync(Jungle);

            FindTopChamps(Mid);
            PopulateTopChampsSync(Mid);

            FindTopChamps(Support);
            PopulateTopChampsSync(Support);

            FindTopChamps(ADC);
            PopulateTopChampsSync(ADC);
        }

        private void CombineRoles(Role current, Role group)
        {
            group.MatchCount += current.MatchCount;

            foreach (Champion i in current.ChampionMap.Keys)
            {
                if (group.ChampionMap.ContainsKey(i))
                {
                    group.ChampionMap[i] += current.ChampionMap[i];
                }
                else
                {
                    group.ChampionMap.Add(i, current.ChampionMap[i]);
                }
            }
        }

        private void PopulateTopChampsSync(Role r)
        {
            switch (r.RoleName)
            {
                case "Top":
                    if (r.TopChamp != 0)
                    {
                        topChamp1.Text = r.TopChamp.ToString() + ", " + r.ChampionMap[r.TopChamp].ToString();
                    }
                    if (r.SecondChamp != 0)
                    {
                        topChamp2.Text = r.SecondChamp.ToString() + ", " + r.ChampionMap[r.SecondChamp].ToString();
                    }
                    break;

                case "Jungle":
                    if (r.TopChamp != 0)
                    {
                        jungleChamp1.Text = r.TopChamp.ToString() + ", " + r.ChampionMap[r.TopChamp].ToString();
                    }
                    if (r.SecondChamp != 0)
                    {
                        jungleChamp2.Text = r.SecondChamp.ToString() + ", " + r.ChampionMap[r.SecondChamp].ToString();
                    }
                    break;

                case "Mid":
                    if (r.TopChamp != 0)
                    {
                        midChamp1.Text = r.TopChamp.ToString() + ", " + r.ChampionMap[r.TopChamp].ToString();
                    }
                    if (r.SecondChamp != 0)
                    {
                        midChamp2.Text = r.SecondChamp.ToString() + ", " + r.ChampionMap[r.SecondChamp].ToString();
                    }
                    break;

                case "Support":
                    if (r.TopChamp != 0)
                    {
                        supportChamp1.Text = r.TopChamp.ToString() + ", " + r.ChampionMap[r.TopChamp].ToString();
                    }
                    if (r.SecondChamp != 0)
                    {
                        supportChamp2.Text = r.SecondChamp.ToString() + ", " + r.ChampionMap[r.SecondChamp].ToString();
                    }
                    break;

                case "ADC":
                    if (r.TopChamp != 0)
                    {
                        carryChamp1.Text = r.TopChamp.ToString() + ", " + r.ChampionMap[r.TopChamp].ToString();
                    }
                    if (r.SecondChamp != 0)
                    {
                        carryChamp2.Text = r.SecondChamp.ToString() + ", " + r.ChampionMap[r.SecondChamp].ToString();
                    }
                    break;

                default:

                    break;
            }
        }

        private void PopulateTopChampsSync(Role Top, Role Jungle, Role Mid, Role Support, Role ADC)
        {   
            if (Top.TopChamp != 0)
            {
                topChamp1.Text = Top.TopChamp.ToString() + ", " + Top.ChampionMap[Top.TopChamp].ToString();
            }
            if (Top.SecondChamp != 0)
            {
                topChamp2.Text = Top.SecondChamp.ToString() + ", " + Top.ChampionMap[Top.SecondChamp].ToString();
            }
 
            if (Jungle.TopChamp != 0)
            {
                jungleChamp1.Text = Jungle.TopChamp.ToString() + ", " + Jungle.ChampionMap[Jungle.TopChamp].ToString();
            }
            if (Jungle.SecondChamp != 0)
            {
                jungleChamp2.Text = Jungle.SecondChamp.ToString() + ", " + Jungle.ChampionMap[Jungle.SecondChamp].ToString();
            }

            if (Mid.TopChamp != 0)
            {
                midChamp1.Text = Mid.TopChamp.ToString() + ", " + Mid.ChampionMap[Mid.TopChamp].ToString();
            }
            if (Mid.SecondChamp != 0)
            {
                midChamp2.Text = Mid.SecondChamp.ToString() + ", " + Mid.ChampionMap[Mid.SecondChamp].ToString();
            }

            if (Support.TopChamp != 0)
            {
                supportChamp1.Text = Support.TopChamp.ToString() + ", " + Support.ChampionMap[Support.TopChamp].ToString();
            }
            if (Support.SecondChamp != 0)
            {
                supportChamp2.Text = Support.SecondChamp.ToString() + ", " + Support.ChampionMap[Support.SecondChamp].ToString();
            }

            if (ADC.TopChamp != 0)
            {
                carryChamp1.Text = ADC.TopChamp.ToString() + ", " + ADC.ChampionMap[ADC.TopChamp].ToString();
            }
            if (ADC.SecondChamp != 0)
            {
                carryChamp2.Text = ADC.SecondChamp.ToString() + ", " + ADC.ChampionMap[ADC.SecondChamp].ToString();
            }
        }

        private void PopulatePopularDataSync(SummonerData data)
        {
            Role mostPlayed = new Role();

            foreach (Role r in data.Roles)
            {
                if (r.MatchCount > mostPlayed.MatchCount)
                {
                    mostPlayed = r;
                }
            }

            commonRoleBox.Text = mostPlayed.RoleName;

            switch (mostPlayed.RoleName)
            {
                case "Top":
                    commonLaneBox.Text = "Top";
                    break;

                case "Jungle":
                    commonLaneBox.Text = "Jungle";
                    break;

                case "Mid":
                    commonLaneBox.Text = "Mid";
                    break;

                case "Support":
                    commonLaneBox.Text = "Bottom";
                    break;

                case "ADC":
                    commonLaneBox.Text = "Bottom";
                    break;

                default:

                    break;
            }

        }

        private static void GetLeagueByDivisionSync(ComboBox region, ComboBox division, ComboBox league, ListBox list)
        {
            var leagueEntries = Riot.LeagueExpV4.GetLeagueEntries(Utility.GetRegion(region.Text), QueueType.RANKED_SOLO_5x5, Utility.GetTier(league.Text), Utility.GetDivision(division.Text));

            for (int i = 0; i < 10; i++)
            {
                SummonerData current = new SummonerData();
                Summoner summoner = new Summoner();

                summoner = Riot.SummonerV4.GetBySummonerName(Utility.GetRegion(region.Text), leagueEntries[i].SummonerName);

                current.Name = leagueEntries[i].SummonerName;
                current.AccountId = summoner.AccountId;

                GetRoleInfoSync(region, current);

                DataList.Add(current);
            }
        }
    }
}
