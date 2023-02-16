using System;

class Program
{
    static void Main(string[] args)
    {

        Assignment assign1 = new Assignment("Cameron Pedro", "Programming");
        Console.WriteLine(assign1.GetSummary());

        MathAssignment assign2 = new MathAssignment("Cash Pedro", "Division", "7.3", "8-19");
        Console.WriteLine(assign2.GetSummary());
        Console.WriteLine(assign2.GetHomeworkList());

        WritingAssignment assign3 = new WritingAssignment("Macey Goetzel", "World War II", "The Aftermath of World War II");
        Console.WriteLine(assign3.GetSummary());
        Console.WriteLine(assign3.GetWritingInformation());
    }
}