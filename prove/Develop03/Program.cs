using System;
using System.Linq;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        //BEHAVIOR BEFORE THE LOOP
        Reference r1 = new Reference("Philipians", 4, 12, 13);
        Scripture s1 = new Scripture("I know how to be abased, and I know how to abound. Everywhere and in all things I have learned both to be full and to be hungry, both to abound and to suffer need. I can do all things through Christ who strengthens me.");
        string _choose;
        Motivation motivation = new Motivation();
        while (true)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine(motivation.Prompter());
            Console.WriteLine();
            Console.WriteLine(r1.GetCompleteReference());
            s1.DisplayScripture();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue or type 'quit' to finish: ");
            _choose = Console.ReadLine();
            if (_choose == "quit")
            {
                Console.WriteLine("Thanks for using this program! ");
                break;
            }
            if (s1.AllWordsHidden())
                break;
            // If we dont use this counter all the text will hide.    
            int _counter = 0;
            while (_counter < 3 && s1.AllWordsHidden() == false)
            {
                s1.HideWords();
                _counter++;
            }

        }

    }
}