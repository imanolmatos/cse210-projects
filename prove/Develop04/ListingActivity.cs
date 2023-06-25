class ListingActivity : Activity
{
       private List<string> prompts = new List<string>()
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };
    private Random rnd = new Random();
    public ListingActivity(string setDescription, string setName, int time)
        : base(setDescription, setName, time) { }
    public void RunListingActivity()
    {
        StartActivity();
        GetReady();
        Console.WriteLine();
        Console.Write("List as many responses as you can yo the following prompt:");
        Console.WriteLine("");
        Console.Write("--- ");
        Console.Write(GetListingPrompt());
        Console.WriteLine(" ---");
        Console.Write("You may begin in: ");
        DisplayTimer(5);
        Console.WriteLine();
        DateTime startime = DateTime.Now;
        DateTime endTime = startime.AddSeconds(_lenghTime);
        int _counter = 0;
        while (DateTime.Now < endTime)
        { 
            Console.Write("> ");
            Console.ReadLine();
            _counter = _counter + 1;
        }
        Console.WriteLine($"You listed {_counter} items!");
        EndActivity();
    }
    public string GetListingPrompt()
    {
        int index = rnd.Next(0, prompts.Count);
        string _displayPrompt = prompts[index];
        return (_displayPrompt);
    }
}
