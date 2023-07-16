using System;
class Program
{
    static void Main(string[] args)
    {
        List<Activity> add = new List<Activity>();
        RunningActivity running = new RunningActivity("30 Nov 2023", 30, 4.8);
        add.Add(running);
        BikeActivity biking = new BikeActivity("25 Nov 2023", 30, 3);
        add.Add(biking);
        SwimmingActivity swim = new SwimmingActivity("24 Nov 2023", 30, 2);
        add.Add(swim);
        foreach (Activity activity in add)
        {
            activity.GetSummary();
        }
    }
}
