using System.Collections.Generic;

public partial class Journal {

    //METHODS 

  List<Entry> _entries = new List<Entry>();


// Comment: I will call the object in entry(The string with all the information but I need that string). I will add that object to the list _entries. 
   public void WelcomeMessage()
    {
    Console.WriteLine("Welcome to your journal. \r\n Please choose an option: \r\n 1. Write. \r\n 2. Display \r\n 3. Load. \r\n 4. Save. \r\n 5. Quit.");
    }
    public void Write()
    {
    Console.WriteLine("Welcome to your journal. \r\nI Please choose an option: \r\nI 1. Write. \r\nI 2. Display \r\nI 3. Load. \r\nI 4. Save. \r\nI 5. Quit.");
    }

    public void Display()
    {
    Console.WriteLine("Welcome to your journal. \r\nI Please choose an option: \r\nI 1. Write. \r\nI 2. Display \r\nI 3. Load. \r\nI 4. Save. \r\nI 5. Quit.");
    }

    public void Entry()
    {
    Console.WriteLine("These are the entries");
    }

    public void Load()
    {
    Console.WriteLine("This will load the file");
    }
    
    public void Save()
    {
      Console.WriteLine("This will load the file");

    }

    public void Quit()
    {
       Console.WriteLine("Thanks for using this program");
    }
    public void Prompt()

    {
      Console.WriteLine("Thanks for using this program");  

    }


