using System.Collections.Generic;
public class Entry

//class models the responsibilities of an Entry and does not include items that do not pertain to an Entry.
// Atributes 
{
    private string _dateTime;
    private string _prompt;
    private string _response;


//Properties
    public string _DateTime { get{return _dateTime;} }
    public string _Prompt { get{return _prompt;}}
    public string _Response  { get{return _response;} }

 // journal entry is written and stored along with the date.
    public Entry(PromptGenerator prompting)
    {
        _prompt = prompting.Prompter();
        Console.WriteLine(_prompt);
        Console.Write("> ");
        _response = Console.ReadLine();
        _dateTime = DateTime.Now.ToString("MM/dd/yyyy/HH:mm:ss");
    }

    public Entry(string dateTime, string prompt, string response)
    {
        _dateTime = dateTime;
        _prompt = prompt;
        _response = response;
    }



    public void Display()
    {
        Console.WriteLine($"Date: {_dateTime}-Prompt: {_prompt}");
        Console.WriteLine(_response);
    }


   




    

}


 









