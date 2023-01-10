using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        List<int> numberList = new List<int>();
        int finalNumber = 0;

        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        numberList.Add(number);

        while (number != 0)
        {
            Console.Write("Enter number: ");
            number = int.Parse(Console.ReadLine());
            numberList.Add(number);
        }
        foreach (int item in numberList)
        {
            finalNumber += item;
        }
        double itemsInList = numberList.Count - 1;

        Console.WriteLine($"Sum: {finalNumber}");
        Console.WriteLine($"Avg: {Math.Round(finalNumber / itemsInList, 3)}");
        Console.WriteLine($"Max: {numberList.Max()}");
    }
}