using System;
using System.Collections.Generic;
//set of writing prompts is chosen from randomly and displayed.
public class PromptGenerator
{
    private List<string> prompts = new List<string>()
    {
        "What was a sad part of my day? " ,
        "What was a happy part of my day? ",
        "How did I see the hand of the Lord in my life today? ",
        "What good action did I do today? ",
        "What is something that I want to remenber of today? "
    };
    private Random rnd = new Random();

    public string Prompter()
    {
        
        int index = rnd.Next(0, prompts.Count);
        string _displayPrompt = prompts[index];    
        return (_displayPrompt);

    }





}
