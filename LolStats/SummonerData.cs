using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LolStats
{
    [Serializable]
    public class SummonerData
    {
        public string Name;
        //public long AverageCS;
        //public long AverageGold;

        [JsonIgnore]
        public string AccountId;

        public List<Role> Roles;

        public SummonerData()
        {
            Name = "";
            //AverageCS = 0;
            //AverageGold = 0;

            Roles = new List<Role>();

            Role Top = new Role();
            Top.RoleName = "Top";
            Roles.Add(Top);

            Role Jungle = new Role();
            Jungle.RoleName = "Jungle";
            Roles.Add(Jungle);

            Role Mid = new Role();
            Mid.RoleName = "Mid";
            Roles.Add(Mid);

            Role Support = new Role();
            Support.RoleName = "Support";
            Roles.Add(Support);

            Role ADC = new Role();
            ADC.RoleName = "ADC";
            Roles.Add(ADC);
        }
    }
}
