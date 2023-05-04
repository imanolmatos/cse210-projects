

public class Resume
{
    public string _personName;
    public List<Job> _listJobs = new List<Job>();

    public void Display()
    {
         Console.WriteLine($"Name: {_personName}");
         Console.WriteLine($"Jobs of {_personName}: ");
        foreach (Job job in _listJobs)
        {
            job.Display();
        }
    }



}