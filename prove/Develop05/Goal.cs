public class Goal
{
    public string Name { get; set; }
    public int PointValue { get; set; }
    public string Description { get; set; }
    public bool IsComplete { get; set; }

    public virtual int GetPoints()
    {
        return IsComplete ? PointValue : 0;
    }
}