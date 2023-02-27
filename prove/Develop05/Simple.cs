class Simple : Goal
{
    private string _name;
    protected override void CreateGoal()
    {
        Console.WriteLine("What is the name of your goal?");
        _name = Console.ReadLine();
    }
}