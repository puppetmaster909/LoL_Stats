using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LolStats
{
    [Serializable]
    public class SummonerList
    {
        public List<SummonerData> Summoners;

        public SummonerList()
        {
            Summoners = new List<SummonerData>();
        }
    }
}
