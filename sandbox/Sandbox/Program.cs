using System;
using System.Collections.Generic;

    public class PromptGenerator{
        public static void Main(String[] args)
        {
            List <string> thePrompts = new List<string>();
            thePrompts.Add("What was a sad part of my day? ");
            thePrompts.Add("What was a happy part of my day?  ");
            thePrompts.Add("How did I see the hand of the Lord in my life today? ");
            thePrompts.Add(" What good action did I do today? ");
            thePrompts.Add("What is something that I want to remenber of today? ");

            var rnd = new Random();
            int index = rnd.Next(thePrompts.Count);

            string info = thePrompts[index];

            Console.WriteLine(info);
        }

    // Comment: It is the same situation with   public static void Main(String[] args) without that code I get error in my list.
      
 }





