public class LectureEvent : Event
{
    private string _speakerName = "Speaker Name";
    private int _capacity = 0;
    public LectureEvent(
        string title,
        string description,
        string date,
        string time,
        Address address,
        string type,
        string speakerName,
        int capacity
    )
        : base(title, description, date, time, address, type)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }
    public override void StandardDetails()
    {
        Console.WriteLine("Standard Description:");
        Console.WriteLine(
            $"Title: {_eventTitle}, Description: {_description}, Date and Time : {_date}, {_time}"
        );
        Console.WriteLine($"Address: {_address.ReturnAddress()}");
    }
    public override void FullDetails()
    {
        Console.WriteLine("Full Description:");      
        Console.WriteLine(
            $"Type of Event: {_type}. Title: {_eventTitle}, Description: {_description}, Date and Time : {_date}, {_time}"
        );
        Console.WriteLine($"Address: {_address.ReturnAddress()}");
        Console.WriteLine($"Name of Speaker: {_speakerName}");
        Console.WriteLine($"Capacity: {_capacity}");
    }

    public override void ShortDetails()
    {
        Console.WriteLine("Short Description:");
        Console.WriteLine($"Type of Event: {_type}. Title: {_eventTitle}, Date: {_date}");
    }
}
