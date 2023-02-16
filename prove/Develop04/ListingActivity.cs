using System;
using System.Threading;


class ListingActivity : Activity
{
    private readonly string[] prompts = new string[]
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    protected override string _name => "Listing Activity";
    protected override string _description => "List as many items as you can on a given prompt.";

    protected override void GetActivity(DateTime futureTime)
    {
        // Select a random prompt
        Random random = new Random();
        int promptIndex = random.Next(prompts.Length);
        string prompt = prompts[promptIndex];
        Console.WriteLine($"Prompt: {prompt}");

        // Countdown to begin thinking
        for (int i = 3; i > 0; i--)
        {
            Console.WriteLine($"Starting in {i}...");
            Thread.Sleep(1000);
        }
        Console.WriteLine("Start listing!");

        // List as many items as possible for the specified duration
        int itemCounter = 0;
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < futureTime)
        {
            string item = Console.ReadLine();
            if (string.IsNullOrEmpty(item))
            {
                break;
            }
            itemCounter++;
        }

        // Display the number of items that were entered
        Console.WriteLine($"You listed {itemCounter} items!");
        Thread.Sleep(2000);
    }
}
