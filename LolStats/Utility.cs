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
                case "NA1":
                    return MingweiSamuel.Camille.Enums.Region.NA1;

                case "BR":
                    return MingweiSamuel.Camille.Enums.Region.BR1;

                case "EUNE":
                    return MingweiSamuel.Camille.Enums.Region.EUN1;

                case "EUW":
                    return MingweiSamuel.Camille.Enums.Region.EUW1;

                case "JP":
                    return MingweiSamuel.Camille.Enums.Region.JP1;

                case "KR":
                    return MingweiSamuel.Camille.Enums.Region.KR;

                case "OCE":
                    return MingweiSamuel.Camille.Enums.Region.OC1;

                case "TR":
                    return MingweiSamuel.Camille.Enums.Region.TR1;

                case "RU":
                    return MingweiSamuel.Camille.Enums.Region.RU;

                default:
                    return MingweiSamuel.Camille.Enums.Region.NA1;
            }
        }

        //public static string GetTier(string inputTier)
        //{
        //    switch (inputTier)
        //    {
        //        case "Challenger":
        //            return "CHALLENGER";

        //        case "GrandMaster":
        //            return "GRANDMASTER";
        //        case "Master":
        //            return "MASTER";
        //        case "Diamond":
        //            return "DIAMOND";
        //        case "Platinum":
        //            return "PLATINUM";
        //        case "Gold":
        //            return "GOLD";
        //        case "Silver":
        //            return "SILVER";
        //        case "Bronze":
        //            return "BRONZE";
        //        case "Iron":
        //            return "IRON";
        //        default:
        //            return "CHALLENGER";
        //    }
        //}

        public static Tier GetTier(string inputTier)
        {
            switch (inputTier)
            {
                case "Challenger":
                    return Tier.CHALLENGER;

                case "GrandMaster":
                    return Tier.GRANDMASTER;
                case "Master":
                    return Tier.MASTER;
                case "Diamond":
                    return Tier.DIAMOND;
                case "Platinum":
                    return Tier.PLATINUM;
                case "Gold":
                    return Tier.GOLD;
                case "Silver":
                    return Tier.SILVER;
                case "Bronze":
                    return Tier.BRONZE;
                case "Iron":
                    return Tier.IRON;
                default:
                    return Tier.CHALLENGER;
            }
        }

        //public static MingweiSamuel.Camille.Enums.Division GetDivision(string inputDivision)
        //{
        //    switch (inputDivision)
        //    {
        //        case "I":
        //            return Division.I;
        //        case "II":
        //            return Division.II;
        //        case "III":
        //            return Division.III;
        //        case "IV":
        //            return Division.IV;
        //        case "V":
        //            return Division.V;
        //        default:
        //            return Division.I;
        //    }
        //}

        public static MingweiSamuel.Camille.Enums.Division GetDivision(string inputDivision)
        {
            switch (inputDivision)
            {
                case "I":
                    return Division.I;
                case "II":
                    return Division.II;
                case "III":
                    return Division.III;
                case "IV":
                    return Division.IV;
                case "V":
                    return Division.V;
                default:
                    return Division.I;
            }
        }

        #endregion
    }
}
