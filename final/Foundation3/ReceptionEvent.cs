public class ReceptionEvent : Event
{
    private string _rsvpEmail = "This is the rsvp email";
    public ReceptionEvent(
        string title,
        string description,
        string date,
        string time,
        Address address,
        string type,
        string rsvp
    )
        : base(title, description, date, time, address, type)
    {
        _rsvpEmail = rsvp;
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
        Console.WriteLine("Full Description. ");
        Console.WriteLine(
            $"Type of Event: {_type}. Title: {_eventTitle}, Description: {_description}, Date and Time : {_date}, {_time}"
        );
        Console.WriteLine($"Address: {_address.ReturnAddress()}");
        Console.WriteLine("");
        Console.WriteLine($"{_rsvpEmail}");
    }

    public override void ShortDetails()
    {
        Console.WriteLine("Short Description:");
        Console.WriteLine($"Type of Event: {_type}. Title: {_eventTitle}, Date: {_date}");
    }
}
