using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        // JOBS    
        Job job1  = new Job();

        job1._jobTitle = "Sales Represantive";
        job1._company = "Claro";
        job1._jobEnd = 2020;
        job1._jobStart = 2015;

        Job job2  = new Job();

        job2._jobTitle = "Customer Service Representative";
        job2._company = "Apple";
        job2._jobEnd = 2022;
        job2._jobStart = 2020;
        
    //    job1.Display();
    //    job2.Display();
    // RESUME
    Resume theResume = new Resume();
    theResume._personName = "Sarah Parker";
    theResume._listJobs.Add(job1);
    theResume._listJobs.Add(job2);
    theResume.Display();

    }
}

