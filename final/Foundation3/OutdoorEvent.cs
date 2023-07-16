public class OutdoorEvent : Event
{
    private string _weather = "Its a good time";
    public OutdoorEvent(
        string title,
        string description,
        string date,
        string time,
        Address address,
        string type,
        string weather
    )
        : base(title, description, date, time, address, type)
    {
        _weather = weather;
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
        Console.WriteLine("Full Description.");
        Console.WriteLine(
            $"Type of Event: {_type}. Title: {_eventTitle}, Description: {_description}, Date and Time : {_date}, {_time}"
        );
        Console.WriteLine($"Address: {_address.ReturnAddress()}");
        Console.WriteLine($"Condition of Weather for that time: {_weather}");
    }

    public override void ShortDetails()
    {
        Console.WriteLine("Short Description");
        Console.WriteLine($"Type of Event: {_type}. Title: {_eventTitle}, Date: {_date}");
    }
}
