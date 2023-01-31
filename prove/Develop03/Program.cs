using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture s = new Scripture();

        string fullScript = s.GetScripture(); 
        string reference = fullScript.Split(".")[0].Trim();
        string scriptText = fullScript.Split(".")[1].Trim();
        
        Console.WriteLine($"{reference} {scriptText}");

    }
}