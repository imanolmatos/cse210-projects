

public class Job
{
    public string _jobTitle;
    public string  _company;
    public int _jobStart;
    public int _jobEnd;



    public void Display()
    {
         Console.WriteLine($"{_jobTitle} ({_company}) {_jobStart}-{_jobEnd}");
    }



}

