using System;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goals = new List<Goal>();
        Menu menu = new Menu(); 
        
        bool running = true;
        bool createRunning = true;
        
        while (running == true)
        {
            int menuChoice = menu.DisplayMenu();
            Goal goal;
            switch(menuChoice)
            {
                case 1:
                    //Show create goal type menu
                    Console.WriteLine($"New Case {menuChoice}");
                    while (createRunning == true)
                    {
                        int createMenuChoice = menu.CreateMenu();
                        switch(createMenuChoice)
                        {
                            case 1:
                                break;
                            case 2:
                                break;
                            case 3:
                                break;
                            case 4:
                                break;
                            default:
                                continue;
                        }
                    }
                    break;
                case 2:
                    Console.WriteLine($"New Case {menuChoice}");
                    break;
                case 3:
                    Console.WriteLine($"New Case {menuChoice}");
                    break;
                case 4:
                    Console.WriteLine($"New Case {menuChoice}");
                    break;
                case 5:
                    Console.WriteLine($"New Case {menuChoice}");
                    break;
                case 6:
                    running = false;
                    Console.WriteLine("QUITTING");
                    break;
                default:
                    Console.WriteLine("Invalid Input. Please try again.");
                    continue;
            }
        }
    }
}