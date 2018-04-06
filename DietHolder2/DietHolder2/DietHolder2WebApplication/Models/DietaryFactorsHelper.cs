using System.Collections.Generic;

namespace DietHolder2WebApplication.Models
{
    public static class DietaryFactorsHelper
    {
        public static Dictionary<DailyActivity, double> TeaFactor()
        {
            return new Dictionary<DailyActivity, double>
            {
                {DailyActivity.Low, 1.2},
                {DailyActivity.Medium, 1.4},
                {DailyActivity.High, 1.7},
                {DailyActivity.VeryHigh, 2}
            };
        }
        public static Dictionary<SomaticType, double> ReductionNeatFactor()
        {
            return new Dictionary<SomaticType, double>
            {
                {SomaticType.Ectomorphic, 0.1},
                {SomaticType.Mesomorphic, 0.15},
                {SomaticType.EndoMorphic, 0.2}
            };
        }
        public static Dictionary<SomaticType, double> WeightGainNeatFactor()
        {
            return new Dictionary<SomaticType, double>
            {
                {SomaticType.Ectomorphic, 0.2},
                {SomaticType.Mesomorphic, 0.15},
                {SomaticType.EndoMorphic, 0.1}
            };
        }
    }
}