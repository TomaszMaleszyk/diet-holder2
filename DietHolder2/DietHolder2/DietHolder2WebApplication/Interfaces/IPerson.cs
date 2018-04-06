using DietHolder2WebApplication.Models;

namespace DietHolder2WebApplication.Interfaces
{
    public interface IPerson
    {
        double Weight { get; set; }
        double Height { get; set; }
        int Age { get; set; }
        Sex Sex { get; set; }
        SomaticType SomaticType { get; set; }
        DailyActivity DailyActivity { get; set; }
        GoalToRealize GoalToRealize { get; set; }
    }
}
