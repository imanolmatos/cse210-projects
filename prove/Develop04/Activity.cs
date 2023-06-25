public class Activity
{
    private string _name;
    private string _description;
    protected int _lenghTime;
    private List<char> _spinner = new List<char>() { '|', '/', '-', '\\' };

    public Activity(string name, string description, int time)
    {
        _name = name;
        _description = description;
        _lenghTime = time;
    }
    public void DisplaySpinner(int second)
    {
        int i = 0;
        int x = 0;
        DateTime startime = DateTime.Now;
        DateTime endTime = startime.AddSeconds(second);
        while (DateTime.Now < endTime)
        {
            Console.Write(_spinner[x]);
            Thread.Sleep(200);
            Console.Write("\b \b");
            i++;
            x = i % _spinner.Count;
        }
    }
    public void DisplayTimer(int duration)
    {
        DateTime startime = DateTime.Now;
        DateTime endTime = startime.AddSeconds(duration);
        while (DateTime.Now < endTime)
            for (int i = duration; i > 0; i--)
            {
                Console.Write(i);
                Thread.Sleep(1000);
                Console.Write("\b \b");
            }
    }
    public void StartActivity()
    {   Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine("");
        Console.WriteLine(_description);
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");
        _lenghTime = int.Parse(Console.ReadLine());
    }

    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplaySpinner(5);
    }
    public void EndActivity()
    {
        Console.WriteLine("");
        Console.WriteLine("Well Done!! ");
        DisplaySpinner(5);
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_lenghTime} seconds of the {_name} Activity.");
        DisplaySpinner(5);
    }
}
