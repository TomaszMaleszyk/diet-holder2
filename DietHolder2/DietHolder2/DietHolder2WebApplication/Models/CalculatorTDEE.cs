using System.Collections.Generic;
using DietHolder2WebApplication.Interfaces;

namespace DietHolder2WebApplication.Models
{
    public static class CalculatorTdee
    {
        private delegate double OperationChooser(double teaValue, SomaticType somaticType);
        public static double GetTdee(IPerson person)
        {
            var bmrValue = CalculatorBmr.GetBmrValue(person);
            var teaValue = GetTeaFactor(bmrValue, person.DailyActivity);
            var tdeeFinalValue = IncludeNeatFactor(teaValue, person.GoalToRealize, person.SomaticType);

            return tdeeFinalValue;
        }

        private static double GetTeaFactor(double bmrValue, DailyActivity dailyActivity)
        {
            var activityDeterminant = DietaryFactorsHelper.TeaFactor();

            foreach(var item in activityDeterminant)
            {
                if(dailyActivity.Equals(item.Key))
                {
                    var dailyCaloriesToEatValue = bmrValue * item.Value;
                    return dailyCaloriesToEatValue;
                }
            }
            return -1;
        }
        private static double IncludeNeatFactor(double teaValue, GoalToRealize goalToRealize, SomaticType somaticType)
        {
            var goalToRealizePicker = NeatFactorPicker();

            foreach(var item in goalToRealizePicker)
            {
                if(item.Key.Equals(goalToRealize))
                {
                    return item.Value.Invoke(teaValue, somaticType);
                }
            }
            return -1;
        }
        private static Dictionary<GoalToRealize, OperationChooser> NeatFactorPicker()
        {
            return new Dictionary<GoalToRealize, OperationChooser>
            {
                {GoalToRealize.WeightReduction, IncludeNeatFactorReduction},
                {GoalToRealize.WeightGain, IncludeNeatFactorWeighGain}
            };
        }

        private static double IncludeNeatFactorReduction(double teaValue, SomaticType somaticType)
        {
            var reductionCoefficient = DietaryFactorsHelper.ReductionNeatFactor();

            foreach(var coefficient in reductionCoefficient)
            {
                if(somaticType.Equals(coefficient.Key))
                {
                    return teaValue - teaValue * coefficient.Value;
                }
            }
            return -1;
        }
        private static double IncludeNeatFactorWeighGain(double teaValue, SomaticType somaticType)
        {
            var weightGainCoefficient = DietaryFactorsHelper.WeightGainNeatFactor();

            foreach(var coefficient in weightGainCoefficient)
            {
                if(somaticType.Equals(coefficient.Key))
                {
                    return teaValue + teaValue * coefficient.Value;
                }
            }
            return -1;
        }
    }

}