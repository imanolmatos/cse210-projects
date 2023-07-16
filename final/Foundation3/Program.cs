using System;

class Program
{
    static void Main(string[] args)
    { //Outdoor Event. utdoorEvent(string title, string description, string date, string time, string address, string type, string weather)
        //(string city, string state, string address, string country)
        Console.WriteLine();
        Console.WriteLine("Outdoor Event");
        Console.WriteLine("");
        OutdoorEvent outdoor = new OutdoorEvent(
            "Know the English Authors",
            "Learn more about Shakeaspere, Dickens, Orwell and others",
            "8/15/2023",
            "20:00",
            new Address("Salt Lake City", "Utah","Utah Park 2039","United States"),
            "Outdoor Event",
            "Sunny Day"
        );
        outdoor.StandardDetails();
        Console.WriteLine();
        outdoor.FullDetails();
        Console.WriteLine();
        outdoor.ShortDetails();

         //Reception Event string title, string description, string date, string time, string address, string type,  string rsvp)
        Console.WriteLine("");
        Console.WriteLine("Reception Event");
        ReceptionEvent reception  = new ReceptionEvent(
            "Baby Shower",
            "Know the sex of our baby! ",
            "11/20/2023",
            "21:00",
            new Address("Ontario City", "Ontario","Canada Street #3001","Canada"),
            "Reception Event",
            "Let us know, RSVP. -John and Mary"
        );
        reception.StandardDetails();
        Console.WriteLine();
        reception.FullDetails();
        Console.WriteLine();
        reception.ShortDetails();
        //Lecture Event (string title, string description, string date, string time, string address, string type, string speakerName, int capacity)
        Console.WriteLine("");
        Console.WriteLine("Lecture Event");
        Console.WriteLine("");
        LectureEvent lecture  = new LectureEvent(
            "Know the Latin Music",
            "Learn about the origins of  Merengue, Bachata, Salsa and more! ",
            "10/15/2023",
            "17:00",
            new Address("Lima, Miraflores", "Lima","Calle El Dorado #49","Perú"),
            "Lecture Event",
            "Juan Luis Guerra",
            500
        );
        lecture.StandardDetails();
        Console.WriteLine();
        lecture.FullDetails();
        Console.WriteLine();
        lecture.ShortDetails();
    }
}
