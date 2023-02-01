class Update
{
    private static List<string> text = new List<string>();
    public string UpdateScripture(string rawScript)
    {
        Random rand = new Random();
        string reference = rawScript.Split(".")[0].Trim();
        string scriptText = rawScript.Split(".")[1].Trim();

        //MODIFY SCRIPTTEXT TO REMOVE RANDOM WORDS AND CONTINUE
        //List<string> result = scriptText.ToList();

        //Console.WriteLine(result);
        
        //Update full scripture string with new random missing words
        string updatedScripture = $"{reference} {scriptText}";

        return updatedScripture;
    }
}