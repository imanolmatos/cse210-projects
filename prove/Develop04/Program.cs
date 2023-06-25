class Program
{
    static void Main(string[] args)
    {
        //    1. Have a menu system to allow the user to choose an activity.
        while (true)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Start interests activity");
            Console.WriteLine("  5. Quit");
            Console.Write("Select a choice from the menu: ");
            int _length = 0;
            string userInput = Console.ReadLine();
            int _choose = int.Parse(userInput);
            if (_choose == 1)
            {
                BreathingActivity activity = new BreathingActivity("Breathing", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", _length);
                activity.RunBreathingActivity();
                Console.WriteLine("");
            }
            else if (_choose == 2)
            {
                Console.WriteLine("");
                ReflectionActivity activity = new ReflectionActivity("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilence. This will help you recognize the power you have and how you can use it in other aspects of your life.", _length);
                activity.RunReflectionActivity();
            }

            else if (_choose == 3)
            {
                Console.WriteLine("");
                ListingActivity activity = new ListingActivity("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", _length);
                activity.RunListingActivity();
            }
            else if (_choose == 4)
            {
                Console.WriteLine("");
                InterestActivity activity = new InterestActivity("Interests", "This activity will help you know more about you by helping you to list interests that you have in many fields. We hope you can discover something new about you.", _length);
                activity.RunInterestActivity();
            }

            else if (_choose == 5)
            {
                Console.WriteLine("");
                Console.WriteLine("Thanks for using this program.");
                break;
            }
        }
    }
}