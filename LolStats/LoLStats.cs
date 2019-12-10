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

        private string ApiKey = "RGAPI-8797214a-0b32-4d62-89fd-4701daffedaa";
        private static readonly Uri SummonerByNameBaseAddress = new Uri("https://na1.api.riotgames.com/lol/summoner/v4/summoners");

        private static RiotApi Riot;
        private static List<SummonerData> DataList;

        private bool StatsByLeague = true;


        #endregion

        public LoLStatsMain()
        {
            InitializeComponent();
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
                    && IsValidEntry(divisionBox, divisionBox.Text))
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
                    && summonerNameBox.Text.Length != 0)
                {
                    searchButton.Enabled = true;
                }
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
            if (StatsByLeague)
            {

            }
            else
            {
                GetSummonerSync(regionBox, summonerNameBox.Text);
                foreach(SummonerData s in DataList)
                {
                    GetRoleInfoSync(top10Summoners, regionBox, s);
                }
            }

        }

        #endregion

        #region Private Methods

        public static bool CheckResponse(ComboBox region, string name, RiotApi riot)
        {
            bool gotResponse = false;

            HttpClient client = new HttpClient
            {
                BaseAddress = SummonerByNameBaseAddress
            };

            

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

        //private static async Task GetSummonerAsync(ComboBox region, string summonerName)
        //{
        //    await Riot.SummonerV4.GetBySummonerName(Utility.GetRegion(region.Text), summonerName);
        //}

        // Gets summoner by name and adds their data to DataList

        private static void GetSummonerSync(ComboBox region, string name)
        {
            Summoner summoner;
            summoner = Riot.SummonerV4.GetBySummonerName(Utility.GetRegion(region.Text), name);

            SummonerData currentData = new SummonerData();
            currentData.Name = summoner.Name;
            currentData.Level = summoner.SummonerLevel;
            currentData.AccountId = summoner.AccountId;

            DataList.Add(currentData);
        }

        private static void GetRoleInfoSync(ListBox list, ComboBox region, SummonerData current)
        {
            Matchlist matchlist;
            matchlist = Riot.MatchV4.GetMatchlist(Utility.GetRegion(region.Text), current.AccountId);

            int i = 0;
            
            foreach (MatchReference m in matchlist.Matches)
            {
                list.Items.Add(i);
                i++;

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

        private void CalculateTopChamps(ListBox listBox, SummonerData current)
        {
            listBox.Items.Add(current.Name);

            foreach (Role r in current.Roles)
            {
                FindTopChamps(r);
                PopulateTopChamps(r);
            }
        }

        private void PopulateTopChamps(Role r)
        {
            switch (r.RoleName)
            {
                case "Top":
                    topChamp1.Text = r.TopChamp.ToString() + ", " + r.ChampionMap[r.TopChamp].ToString();
                    topChamp2.Text = r.SecondChamp.ToString() + ", " + r.ChampionMap[r.SecondChamp].ToString();
                    break;

                case "Jungle":
                    jungleChamp1.Text = r.TopChamp.ToString() + ", " + r.ChampionMap[r.TopChamp].ToString();
                    jungleChamp2.Text = r.SecondChamp.ToString() + ", " + r.ChampionMap[r.SecondChamp].ToString();
                    break;

                case "Mid":
                    midChamp1.Text = r.TopChamp.ToString() + ", " + r.ChampionMap[r.TopChamp].ToString();
                    midChamp2.Text = r.SecondChamp.ToString() + ", " + r.ChampionMap[r.SecondChamp].ToString();
                    break;

                case "Support":
                    supportChamp1.Text = r.TopChamp.ToString() + ", " + r.ChampionMap[r.TopChamp].ToString();
                    supportChamp2.Text = r.SecondChamp.ToString() + ", " + r.ChampionMap[r.SecondChamp].ToString();
                    break;

                case "ADC":
                    carryChamp1.Text = r.TopChamp.ToString() + ", " + r.ChampionMap[r.TopChamp].ToString();
                    carryChamp2.Text = r.SecondChamp.ToString() + ", " + r.ChampionMap[r.SecondChamp].ToString();
                    break;

                default:

                    break;
            }
        }

        private static void FindTopChamps(Role input)
        {
            int topChamp = 0;
            int secondChamp = -1;

            foreach (int i in input.ChampionMap.Keys)
            {
                if(input.ChampionMap[i] > secondChamp)
                {
                    secondChamp = i;
                }
                if (input.ChampionMap[i] > topChamp)
                {
                    secondChamp = topChamp;
                    topChamp = i;
                }
            }

            input.TopChamp = topChamp;
            input.SecondChamp = secondChamp;

            //return input;
        }

        #endregion

        //public Summoner GetSummonerAsync()
        //{
        //    Summoner summoner;
        //    summoner = Riot.SummonerV4.GetBySummonerName(Utility.GetRegion(summonerNameBox.Text), summonerNameBox.Text);
        //    return summoner;
        //}
    }
}
