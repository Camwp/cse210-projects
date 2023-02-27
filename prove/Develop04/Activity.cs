using System.Threading;

abstract class Activity 
{
    protected int _duration;
    protected DateTime _startTime;
    protected DateTime _futureTime;
    

    protected abstract string _name { get; }
    protected abstract string _description { get; }

    protected abstract void GetActivity(DateTime futureTime);
     
    protected virtual void Prepare()
    {
        Console.WriteLine($"Get ready for {_name}!");
        Thread.Sleep(2000);
    }
    protected virtual void EndActivity(DateTime _futureTime)
    {
        Console.WriteLine($"Good job! You completed {_name} for {_duration} seconds.");
        Thread.Sleep(2000);
    }
    public void Start()
    {
        Console.WriteLine(_description);
        Console.Write("Enter the duration of the activity in seconds: ");
        _duration = int.Parse(Console.ReadLine());
        _startTime = DateTime.Now;
        _futureTime = _startTime.AddSeconds(_duration);
        Prepare();
        GetActivity(_futureTime);
        EndActivity(_futureTime);
    }
    public void PlayAnim(DateTime animTime)
    {
        while (DateTime.Now < animTime)
        {
            Console.Write("+");

            Thread.Sleep(500);

            Console.Write("\b \b"); // Erase the + character
            Console.Write("-"); // Replace it with the - character  
            
            Thread.Sleep(500);
            
            Console.Write("\b \b"); // Erase the + character
        }
        

    }
        

}