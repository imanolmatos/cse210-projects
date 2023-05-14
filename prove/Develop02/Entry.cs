
using System.Collections.Generic;
public class Entry
{

public string _dateTime;
public string _prompt;
public string _response; 

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
        
        public void Display(){
            Console.WriteLine($"{_dateTime}, {info}, {_response}");

        }

        public void Add(){

        string _Add = ($"{_dateTime}, {info}, {_response}");
        }

        

        }


      
 }

// Commentary: I want to use my classes and information as public, but it seems to be that in order to work with lists I should use this code:    public static void Main(String[] args). By using this I don't know how I can call my variables in other class





















