using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");
        int intGuess = -1;
        int numTries = 0;
        string tries = "tries";
        
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        Console.WriteLine($"Random number generated successfully.{magicNumber}");

        while (intGuess != magicNumber)
        {
            numTries += 1;
            Console.Write("What is your guess? ");
            intGuess = int.Parse(Console.ReadLine());

            if (intGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (intGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
        }

        if (numTries == 1)
        {
            tries = "try";
        }

        Console.WriteLine($"You guessed it! It took {numTries} {tries}");
        
    }
}