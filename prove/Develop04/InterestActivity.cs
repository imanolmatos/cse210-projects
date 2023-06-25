class InterestActivity : Activity
{
       private List<string> prompts = new List<string>()
    {
        "You can think: In arts.",
        "You can think: In music.",
        "You can think: In Work",
        "You can think: In a field to Learn.",
        "You can think: In books.",
        "You can think: In a general topic."
    };
    private Random rnd = new Random();
    public InterestActivity(string setDescription, string setName, int time)
        : base(setDescription, setName, time) { }
    public void RunInterestActivity()
    {
        StartActivity();
        GetReady();
        Console.WriteLine();
        Console.WriteLine("List as many interests as you can. ");
        Console.Write("You may begin in: ");
        DisplayTimer(5);
        Console.WriteLine();
        DateTime startime = DateTime.Now;
        DateTime endTime = startime.AddSeconds(_lenghTime);
        int _counter = 0;
        while (DateTime.Now < endTime)
        {   Console.Clear();
            Console.WriteLine(GetListingPrompt());
            Console.Write("> ");
            Console.ReadLine();
            _counter = _counter + 1;
        }
        Console.WriteLine($"You listed {_counter} interests!");
        EndActivity();
    }
    public string GetListingPrompt()
    {
        int index = rnd.Next(0, prompts.Count);
        string _displayPrompt = prompts[index];
        return (_displayPrompt);
    }
}
