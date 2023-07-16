using System;
class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        while (true)
        {
            Console.WriteLine($"You have {manager.TotalAmountPoints()} points");
            Console.WriteLine("");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Reduce Points(Bad habit)");
            Console.WriteLine("  7. Quit");
            Console.Write("Select a choice from the menu: ");
            string userInput = Console.ReadLine();
            int _choose = int.Parse(userInput);
            if (_choose == 1)
            {
                manager.AddGoal();
            }
            else if (_choose == 2)
            {
             manager.PrincipalDisplay();
            }
            else if (_choose == 3)
            {
            manager.SaveToFile();
            }
            else if (_choose == 4) 
            {
            manager.LoadFromFile();
            }
            else if (_choose == 5) 
            { 
            manager.RecordEvent();
            }
            else if (_choose == 6)
            {Console.WriteLine("How many points are you going to reduce? ");
             int _reducePoints = int.Parse(Console.ReadLine());
             manager.ReducePoints(_reducePoints);
            }
            else if (_choose == 7)
            {
                Console.WriteLine("Thanks for using this program!");
                break;
            }
        }
    }
}
