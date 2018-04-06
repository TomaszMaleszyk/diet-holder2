using DietHolder2WebApplication.Interfaces;

namespace DietHolder2WebApplication.Models
{
    public class Person : IPerson
    {
        public double Weight { get; set; }
        public double Height { get; set; }
        public int Age { get; set; }
        public Sex Sex { get; set; }
        public SomaticType SomaticType { get; set; }
        public DailyActivity DailyActivity { get; set; }
        public GoalToRealize GoalToRealize { get; set; }
    }

    public enum Sex
    {
        Male,
        Female
    }
    public enum SomaticType
    {
        Ectomorphic,
        Mesomorphic,
        EndoMorphic,
    }
    public enum DailyActivity
    {
        Low,
        Medium,
        High,
        VeryHigh
    }
    public enum GoalToRealize
    {
        WeightReduction,
        WeightGain
    }
}