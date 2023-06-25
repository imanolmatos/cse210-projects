public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description, int time)
        : base(name, description, time) { }
    public void RunBreathingActivity()
    {   StartActivity();
        GetReady();
        DateTime startime = DateTime.Now;
        DateTime endTime = startime.AddSeconds(_lenghTime);
        while (DateTime.Now < endTime)
        {   Console.WriteLine();
            Console.Write("Breathe in...");
            DisplayTimer(6);
            Console.WriteLine();
            Console.Write("Now breathe out...");
            DisplayTimer(4);
            Console.WriteLine("");
        }
        EndActivity();
    }
}
// Comment to update git