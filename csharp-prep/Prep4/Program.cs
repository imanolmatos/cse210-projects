using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        List<float> numbers = new List<float>();
        float givenNumber = -1;
        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        while (givenNumber != 0)
        {Console.Write("Enter number: ");   
         string given = Console.ReadLine();
         givenNumber = float.Parse(given);
         numbers.Add(givenNumber);  
        
        
        if (givenNumber == 0)
        {
          break;
        }

       
        }   
        float count = numbers.Count;
        float minus = count - 1; 
        float sum = numbers.Sum();
         float average = sum / minus;
         float max = numbers.Max();       
         Console.WriteLine($"The Sum is {sum} ");
         Console.WriteLine($"The average is {average}");
        Console.WriteLine($"The largest number is {max}"); 
      
       }
        // numbers.Add()  

}
    // Console.WriteLine("What is your guess? ");
    //         string guess = Console.ReadLine();
    //         numberGuess = float.Parse(guess);
// numbers = []
// a_number = ""
// total = 0
// division = -1
// average = 0
// largest = 0
// print("")
// print("Enter a list of numbers, type 0 when finished.")
// while a_number != 0:
//     a_number = int(input("Enter number: "))
//     numbers.append(a_number) 
//     division = (division + 1)
// if a_number == 0:
//         for a_number in numbers:
//             total = (a_number + total)
// largest = max(numbers) 
// average = total / division
// print(f"The sum is {total}")
// print(f"The average is: {average}")
// print(f"The largest number is: {largest} ")