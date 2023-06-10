using System;
using System.Collections.Generic;
//set of writing prompts is chosen from randomly and displayed.
public class Motivation
{
    private List<string> prompts = new List<string>()
    {
        "You are great! " ,
        "You can do it!  ",
        "Today will be a good day.",
        "A good day to be grateful.",
        "You can learn everything.",
        "A good day to learn.",
        "You can learn this.",
        "God will help you."
    };
    private Random rnd = new Random();

    // public PromptGenerator(){}

    public string Prompter()
    {

        int index = rnd.Next(0, prompts.Count);
        string _displayPrompt = prompts[index];
        return (_displayPrompt);

    }
}