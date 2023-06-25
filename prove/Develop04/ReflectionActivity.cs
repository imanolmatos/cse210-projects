public class ReflectionActivity : Activity
{
    private List<string> prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else. ",
        "Think of a time when you did something really difficult. ",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless. ",
        "Think of a time when you need to ask for help. ",
        "Think of a time when you started a proyect. ",
        "Think of a time when you learn something new. ",
        "Think of a time when you get a job. "
    };
    private List<string> questions = new List<string>()
    {
        "Why was this experience meaningful to you? ",
        "Have you ever done anything like this before? ",
        "How did you get started? ",
        "How did you feel when it was complete? ",
        "What made this time different than other times when you were not as successful? ",
        "What is your favorite thing about this experience? ",
        "What could you learn from this experience that applies to other situations? ",
        "What did you learn about yourself through this experience? ",
        "How can you keep this experience in mind in the future? "
    };
    private Random rnd = new Random();

    public ReflectionActivity(string setName, string setDescription, int setTime)
        : base(setName, setDescription, setTime) { }

    public void RunReflectionActivity()
    {
        StartActivity();
        GetReady();
        Console.WriteLine("");
        DateTime startime = DateTime.Now;
        DateTime endTime = startime.AddSeconds(_lenghTime);
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.Write(" --- ");
        Console.Write(GetPrompt());
        Console.Write(" ---");
        Console.WriteLine("\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadKey();
        Console.WriteLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to your experience. ");
        Console.Write("You may begin in: ");
        DisplayTimer(5);
        Console.WriteLine("");
        Console.Clear();
        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            Console.Write(GetQuestion());
            DisplaySpinner(10);
            Console.WriteLine();     
        }
        EndActivity();
    }

    public string GetQuestion()
    {
        int index = rnd.Next(0, questions.Count);
        string _displayPrompt = questions[index];
        return (_displayPrompt);
    }

    public string GetPrompt()
    {
        int index = rnd.Next(0, prompts.Count);
        string _displayPrompt = prompts[index];
        return (_displayPrompt);
    }
}
