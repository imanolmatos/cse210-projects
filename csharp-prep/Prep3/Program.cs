using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,20);
        float numberGuess = 1;
        while (number != numberGuess)
        {
            // Console.WriteLine("What is the magic number? ");
            // string magic  = Console.ReadLine();
            // number = float.Parse(magic);    
            Console.WriteLine("What is your guess? ");
            string guess = Console.ReadLine();
            numberGuess = float.Parse(guess);

            if (number > numberGuess)
            {Console.WriteLine("Higher");
            }

            else if (number < numberGuess)
            {Console.WriteLine("Lower");

            }
            else 
            {Console.WriteLine("You guessed it!");
            }
        }




//         while magic_number != guess:
//     if magic_number > guess:
//         print("Higher")
//     elif magic_number < guess:
//         print("Lower")
//     guess = int(input("What is your guess? "))
// else: 
//     print("You guessed it!")



    }
}