using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DietHolder2ClientWPF.Models
{
    public static class MacronutrientsDistibutionCalculator
    {
        public static Dictionary<Macronutrients, double> GetMacrosDistribution(double tdeeValue)
        {
            var macrosDistribution = new Dictionary<Macronutrients, double>();

            var carbo = 0.55 * tdeeValue;
            var protein = 0.15 * tdeeValue;
            var fat = 0.3 * tdeeValue;

            macrosDistribution.Add(Macronutrients.Carbo,carbo);
            macrosDistribution.Add(Macronutrients.Protein, protein);
            macrosDistribution.Add(Macronutrients.Fat, fat);

            return macrosDistribution;
        }
    }

    public enum Macronutrients
    {
        Carbo,
        Protein,
        Fat
    }
}
