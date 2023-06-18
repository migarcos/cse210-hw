using System;

class Entry {
    public string _dateEntry, _prompt, _response;
    public int _entryNum = 1;

    public Entry()
    {

    } 

    public void DisplayEntry()
    {
        Console.Write($"Date: {_dateEntry} -");
        Console.WriteLine($" {_prompt}");
        Console.WriteLine($"Entry - {_response}\n");
    }

    public void GetEntryAsCSV() 
    {
        
    }

}