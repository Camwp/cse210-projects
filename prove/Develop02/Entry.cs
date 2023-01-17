class Entry
{
    public List<string> _userEntries = new List<string>();
    public List<string> add_entry_to_list(string prompt, string response)
    {
        if (_userEntries.Count == 0)
        {
            Console.WriteLine("No Entries.\n");
        }
        else
        {
            var userEntry = $"Date: {DateTime.Now.ToShortDateString()} - Prompt: {prompt} \nResponse: {response}\n";
            
        
            //What to do with the info stored in the above format
            Console.Write(userEntry);
            _userEntries.Add(userEntry);
            return _userEntries;
        }

    }
}