using System;
using System.Collections.Generic;
using System.IO;

public class Journal

// class models the responsibilities of a Journal and does not include items that do not pertain to a Journal.
{
    public List<Entry> entries = new List<Entry>();
  

//All journal entries can be displayed along with the date and prompt associated with that entry.
    public void Display()
    {
        foreach (Entry entry in entries){
        Console.WriteLine("");
        entry.Display();

        }

    }

    public void AddEntry(PromptGenerator prompting)
    {   	    
       Entry entry = new Entry(prompting);
       entries.Add(entry);
    }
//The journal can be loaded from a file.
    public void LoadFromFile()
    { 
        entries.Clear();
        Console.WriteLine("What is the name of your file? ");
        Console.Write("> " );
        string fileName = Console.ReadLine();
        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");
            string DateTime = parts[0];
            string Prompt = parts[1];
            string Response = parts[2];
            Entry entry = new Entry(DateTime, Prompt, Response);
            entries.Add(entry);



        }
    }


// The journal can be saved to a file.
    public void SaveToFile(List<Entry> entries)
    {


        Console.WriteLine("What is the name of your file? ");
        string fileName = Console.ReadLine();
        
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine($"{entry._DateTime}~~{entry._Prompt}~~{entry._Response}");
            }
        }
    }
}       
