using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");
        //Begin Activity
        var job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "PMDG INC";
        job1._startYear = "2018";
        job1._endYear = "Current";

        var job2 = new Job();
        job2._jobTitle = "Community Manager";
        job2._company = "Cask Protocol";
        job2._startYear = "2022";
        job2._endYear = "Current";

        var myResume = new Resume();
        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume._memberName = "Cameron Pedro";
        myResume.Display();
        
    }
}