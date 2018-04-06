using System.Collections.Generic;

namespace DietHolder2WebApplication.Models
{
    public class DietMacrosDistribuationCalculator
    {
        public static Dictionary<string, double> GetMacrosDistribution(int tdeeValue)
        {
            var macrosDistribution = new Dictionary<string, double>();

            var carbohydrates = 0.55 * tdeeValue / 4;
            var protein = 0.15 * tdeeValue / 4;
            var fat = 0.3 * tdeeValue / 9;

            macrosDistribution.Add("Węglowodany", carbohydrates);
            macrosDistribution.Add("Białko", protein);
            macrosDistribution.Add("Tłuszcze", fat);

            return macrosDistribution;
        }

    }
}