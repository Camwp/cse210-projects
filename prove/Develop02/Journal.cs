using System.IO;
class Journal
{   
    public void savePrompt(string journalEntries, string fileName)
    {

        
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine("This will be the first line in the file.");
            
            // You can use the $ and include variables just like with Console.WriteLine
            string color = "Blue";
            outputFile.WriteLine($"My favorite color is {color}");
        }

        Console.WriteLine($"File saved as {fileName}.txt");

    }
}