using System;
using System.Collections.Generic;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator prompting = new PromptGenerator();
        // Vertical and horizontal whitespace (blank lines and indentation) is correct throughout the program.
        Console.WriteLine("Welcome to the Journal Program:");
    
       
        while (true)
        {  
            Console.WriteLine("Please select one of the following choices: ");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Exit");
            Console.Write("What would you like to do? ");


            string userInput = Console.ReadLine();

            int _choose = int.Parse(userInput);
        
            if (_choose == 1)
            {
              
                journal.AddEntry(prompting);
           
            

            }
            else if (_choose == 2)
            {
                journal.Display();
                Console.WriteLine("");
            }
            else if (_choose == 3)
            {
                journal.LoadFromFile();
            }
            else if (_choose == 4)
            {
                journal.SaveToFile(journal.entries);
              
            }
            else if (_choose == 5)
            {
                Console.WriteLine("Thanks for using this program.");
                break;
            }

             else if (_choose > 5 || _choose < 0)
            {
                Console.WriteLine("Please enter a valid number");
                Console.WriteLine("");
            }
        }
    }
}



