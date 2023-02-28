// SimpleGoal.cs
public class SimpleGoal : Goal
{
    public override int GetPoints()
    {
        return IsComplete ? PointValue : 0;
    }
}