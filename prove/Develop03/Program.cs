using System;

class Program
{
    //Set program as active bool
    static bool _active = true;
    static string _fullScript;

    //Start main class
    static void Main(string[] args)
    {
        //Add instances of classes & clear the console
        Scripture s = new Scripture();
        Update u = new Update();
        Prompt p = new Prompt();
        Console.Clear();
        
        _fullScript = s.GetScripture(); 
        Console.WriteLine(_fullScript.Replace(".", string.Empty));

        //Main While loop
        while (_active)
        {
            //Get user input
            string userInput = p.GetInput();
            Console.Clear();

            //Check their input
            if (userInput == "")
            {
                _fullScript = u.UpdateScripture(_fullScript);
                Console.WriteLine(_fullScript);
            }
            else if (userInput == "quit")
            {
                _active = false;
            }
            else
            {
                Console.WriteLine(_fullScript.Replace(".", string.Empty));
                Console.WriteLine("Please enter a valid input.");
            }
            
        }
    }
}