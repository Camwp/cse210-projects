public class ChecklistGoal : Goal
{
    public int TimesCompleted { get; set; }
    public int RequiredCompletions { get; set; }
    public int BonusPoints { get; set; }

    public override int GetPoints()
    {
        if (TimesCompleted >= RequiredCompletions)
        {
            
            return BonusPoints;
        }
        else
        {
            
            return PointValue;// * TimesCompleted;
        }
    }
}