using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
          while (true)
        {   Console.WriteLine("");     
            Console.WriteLine($"You have {} points");
            Console.WriteLine("");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit")     
            Console.WriteLine("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            int _choose = int.Parse(userInput);
            if (_choose == 1)
            {        
            }
            else if (_choose == 2)
            {            
            }
            else if (_choose == 3)
            {   
            }
            else if (_choose == 4)
            {   
              
            }
            else if (_choose == 5)
            {
            }
            else if (_choose == 6)
            {
                Console.WriteLine("Thanks for using this program!")
                break;
            }
        } 
    }
}