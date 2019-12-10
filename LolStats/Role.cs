using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MingweiSamuel.Camille;

namespace LolStats
{
    [Serializable]
    public class Role
    {
        public string RoleName;
        public int MatchCount;

        public int TopChamp;
        public int SecondChamp;

        // Champion id - number of times played
        public Dictionary<int, int> ChampionMap;

        public Role()
        {
            RoleName = "";
            MatchCount = 0;

            TopChamp = 0;
            SecondChamp = 0;

            ChampionMap = new Dictionary<int, int>();
        }
    }
}
