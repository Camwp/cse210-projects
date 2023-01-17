using System;

class Program
{   
    static string _userInput;
    public List<string> entries = new List<string>();
    static void Main(string[] args)
    {
        var newPrompt = new PromptGenerator();
        var entry = new Entry();
        var journal = new Journal();
        
        while (_userInput != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?: ");
            _userInput = Console.ReadLine();

            if (_userInput == "1")
            {
                var prompt = newPrompt.GeneratePrompt();
                Console.WriteLine(prompt);
                Console.Write($"Entry: ");
                var _userEntry = Console.ReadLine();

                entry.add_entry_to_list(prompt, _userEntry);
                List<string> entries = entry._userEntries;
            } 
            else if (_userInput == "2")
            {
                foreach (string line in entry._userEntries)
                {
                    Console.WriteLine(line);
                }
            }
            else if (_userInput == "3")
            {
                //LOAD JOURNAL FILE
            }
            else if (_userInput == "4")
            {
                Console.WriteLine("What would you like to name this file? ");
                string filename = Console.ReadLine();
                journal.savePrompt(List<string> entries, filename);

            }
            else
            {
                Console.WriteLine("Please make a valid selection. (1 - 5)\n");
            }
            Console.WriteLine("Thanks for taking time to write in your journal.");

        }

    }
}