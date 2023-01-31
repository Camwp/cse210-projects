using System;

class Program
{
    static void Main(string[] args)
    {
        Scripture s = new Scripture();

        string _fullScript = s.GetScripture(); 
        string _reference = _fullScript.Split(".")[0].Trim();
        string _scriptText = _fullScript.Split(".")[1].Trim();

        Console.WriteLine($"{_reference} {_scriptText}");

    }
}