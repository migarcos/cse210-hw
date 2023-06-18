using System;
 
class Journal {
    public List<Entry> _entries = new List<Entry>();

    public Journal()
    {

    }

    public void DisplayJournalEntries()
    {
        foreach(Entry entry in _entries)
        {
            entry.DisplayEntry();
        }
    }    
    public void CreateJournalEntry()
    {
        Entry newEntry = new Entry();
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        newEntry._dateEntry = dateText;
        promptGenerator newPG = new promptGenerator();
        newEntry._prompt = newPG.GetRandomPrompt();
        newEntry._response = Console.ReadLine();

        _entries.Add(newEntry);                           
                
    }

    public void SaveToCSV()
    {   
        Console.WriteLine("Filename: ");
        string journalFile = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(journalFile)) {
            foreach(Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._dateEntry}, {entry._prompt}, {entry._response}");
            }
        }
    }

    public void LoadFromCSV()
    {
        Console.WriteLine("Filename: ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Entry newEntry = new Entry();
            newEntry._dateEntry = parts[0];
            newEntry._prompt = parts[1];
            newEntry._response = parts[2];
            _entries.Add(newEntry);
        }

        DisplayJournalEntries();
    }
}