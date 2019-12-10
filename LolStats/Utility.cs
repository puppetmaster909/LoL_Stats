using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MingweiSamuel.Camille.Enums;

namespace LolStats
{
    public static class Utility
    {
        #region Public Methods

        public static MingweiSamuel.Camille.Enums.Region GetRegion(string inputRegion)
        {
            switch (inputRegion)
            {
                case "NA":
                    return MingweiSamuel.Camille.Enums.Region.NA;

                case "BR":
                    return MingweiSamuel.Camille.Enums.Region.BR;

                case "EUNE":
                    return MingweiSamuel.Camille.Enums.Region.EUNE;

                case "EUW":
                    return MingweiSamuel.Camille.Enums.Region.EUW;

                case "JP":
                    return MingweiSamuel.Camille.Enums.Region.JP;

                case "KR":
                    return MingweiSamuel.Camille.Enums.Region.KR;

                case "OCE":
                    return MingweiSamuel.Camille.Enums.Region.OCE;

                case "TR":
                    return MingweiSamuel.Camille.Enums.Region.TR;

                case "RU":
                    return MingweiSamuel.Camille.Enums.Region.RU;

                default:
                    return MingweiSamuel.Camille.Enums.Region.NA;
            }
        }

        #endregion
    }
}
