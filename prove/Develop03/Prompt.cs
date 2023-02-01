using System;

class Prompt
{
    private static string userInput;
    public string GetInput()
    {
        Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
        userInput = Console.ReadLine();
        
        return userInput;
    }
}