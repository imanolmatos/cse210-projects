using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        // Fraction f1 = new Fraction();
        // Fraction f2 = new Fraction(6);
        // Fraction f3 = new Fraction(6,7);

         Fraction f = new Fraction();

         // 6/7
         f.SetTop(6);
        //  Console.WriteLine(f.GetTop());
         f.SetBottom(7);
        //  Console.WriteLine(f.GetBottom());
        Console.WriteLine(f.GetFractionString());
         Console.WriteLine(f.GetDecimalValue());


         // 1/1
         f.SetTop(1);
        //  Console.WriteLine(f.GetTop());
         f.SetBottom(1);
        //  Console.WriteLine(f.GetBottom());
         Console.WriteLine(f.GetFractionString());
          Console.WriteLine(f.GetDecimalValue());
   

         // 5/1
         f.SetTop(5);
        //  Console.WriteLine(f.GetTop());
         f.SetBottom(1);
        //  Console.WriteLine(f.GetBottom());
         Console.WriteLine(f.GetFractionString());
         Console.WriteLine(f.GetDecimalValue());

        //3/4
         f.SetTop(3);
        //  Console.WriteLine(f.GetTop());
         f.SetBottom(4);
        //  Console.WriteLine(f.GetBottom());
         Console.WriteLine(f.GetFractionString());
         Console.WriteLine(f.GetDecimalValue());

        //1/3
         f.SetTop(1);
        //  Console.WriteLine(f.GetTop());
         f.SetBottom(3);
        //  Console.WriteLine(f.GetBottom());
         Console.WriteLine(f.GetFractionString());
         Console.WriteLine(f.GetDecimalValue());
    

}

    }


  //In your Program.cs file, verify that you can create fractions using all three of these constructors. For example, create an instance for 1/1 (using the first constructor), for 6/1 (using the second constructor), for 6/7 (using the third constructor).




    
    

   
