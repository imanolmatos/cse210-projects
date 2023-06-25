public class Game
{
    public void SaveToFile(List<Entry> entries)
    {
        protected List<Goals> goalsList = new List<Goals>();
        Console.WriteLine("What is the name of your file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in entries)
            ////Properties
            {
                // outputFile.WriteLine($"{entry._DateTime}~~{entry._Prompt}~~{entry._Response}");
            }
        }
    }
      public void AddEntry()
    {   	    
       Goals goals = new Goals();
       entries.Add(entry);
    }
    public void LoadFromFile()
    {
        entries.Clear();
        Console.WriteLine("What is the name of your file? ");
        string fileName = Console.ReadLine();
        string[] lines = File.ReadAllLines(fileName);

        foreach (string line in lines)
        {
            string[] parts = line.Split("~~");
            string dateTime = parts[0];
            string prompt = parts[1];
            string response = parts[2];
            // Entry entry = new Entry(dateTime,prompt,response);
            // entries.Add(entry);
        }
    }

}
