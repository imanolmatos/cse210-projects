using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
                Console.WriteLine("Other Program: ");
        Console.WriteLine("What is your grade percentage? ");
        string grade  = Console.ReadLine();
        float numberGrade = int.Parse(grade);       
        string letter = "";
        if (numberGrade >= 90)
        {
            letter = "A";
        }
        else if (numberGrade >= 80)
        {
            letter = "B";
        }
        else if (numberGrade >= 70)
        {
            letter = "C";
        }
        else if (numberGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"{letter}.");
        if (numberGrade >=70)
        {
            Console.WriteLine("Congratulations, you approved the coursed! ");
        }
        else
        {
             Console.WriteLine("Sorry, you can do it! Try next time. ");
        }
    }
}