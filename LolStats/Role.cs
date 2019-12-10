using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.MatchV4;
using MingweiSamuel.Camille.Enums;
using Newtonsoft.Json;

namespace LolStats
{
    [Serializable]
    public class Role
    {
        [JsonProperty("RoleName")]
        public string RoleName;
        [JsonProperty("MatchCount")]
        public int MatchCount;

        [JsonIgnore]
        public Champion TopChamp;
        [JsonIgnore]
        public Champion SecondChamp;

        public Dictionary<Champion, int> ChampionMap;

        public Role()
        {
            RoleName = "";
            MatchCount = 0;

            TopChamp = 0;
            SecondChamp = 0;

            ChampionMap = new Dictionary<Champion, int>();
        }
    }
}
