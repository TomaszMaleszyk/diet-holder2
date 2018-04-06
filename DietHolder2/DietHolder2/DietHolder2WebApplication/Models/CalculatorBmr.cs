using DietHolder2WebApplication.Interfaces;

namespace DietHolder2WebApplication.Models
{
    public static class CalculatorBmr
    {
        public static double GetBmrValue(IPerson person)
        {
            double bmrValue = 0;

            switch(person.Sex)
            {
                case Sex.Male:
                    bmrValue = 66.5 + 13.7 * person.Weight + 5 * person.Height - 6.8 * person.Age;
                    break;
                case Sex.Female:
                    bmrValue = 655 + 9.6 * person.Weight + 1.85 * person.Height - 4.7 * person.Age;
                    break;
            }
            return bmrValue;
        }
    }
}