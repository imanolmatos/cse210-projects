using System;
using System.Collections.Generic;


// Comment 1: If I don't use partial I get an error.
  partial class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");

    //INSTANCES: 
  
    //Display Welcome message: 
    Journal journal = new Journal();
    journal.WelcomeMessage();

    Console.Write("Please choose an option: ");


    string given = Console.ReadLine();

    _choose = float.Parse(given);
  
  
// Here I can't add an int or float to given

    }
   
  {
    if (_choose == 1)
      {Journal write = new Journal();
      write.Write();
      }
      else if (_choose == 2) 
      {Journal display = new Journal();
      display.Display();
      }
      else if(_choose == 3)
      {Journal load = new Journal();
      load.Load();
      }
      else if (_choose == 4)
      {Journal save = new Journal();
      save.Save();
      }
      else if (_choose == 5)
      {Console.WriteLine("Thanks for using this program.");
      }
  }


}
    
      
