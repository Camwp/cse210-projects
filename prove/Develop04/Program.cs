using System;

class Program
{
    static void Main(string[] args)
    {     
        bool running = true;
        while (running == true)
        {
            Console.Clear();
            int menuNum = DisplayMenu();
            Activity activity;
            switch (menuNum)
            {
                case 1:
                    activity = new BreathingActivity();
                    break;
                case 2:
                    activity = new ListingActivity();
                    break;
                case 3:
                    activity = new ReflectingActivity();
                    break;
                case 4:
                    activity = null;
                    running = false;
                    break;
                default:
                    Console.WriteLine("Invalid input. Please try again.");
                    continue; 
            }

            if (activity != null)
            {
                activity.Start();
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }

    static int DisplayMenu()
    {
        Console.WriteLine("Welcome to the Activity Program.");
        Console.WriteLine("Please make a selection 1-3");

        Console.WriteLine("[1] Breathing Activity");
        Console.WriteLine("[2] Listing Activity");
        Console.WriteLine("[3] Reflecting Activity");
        Console.WriteLine("[4] Quit");

        string mc = Console.ReadLine();
        int menuChoice = Convert.ToInt32(mc);
        return menuChoice;
    }
}