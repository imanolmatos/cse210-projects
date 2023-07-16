public abstract class Event 
{
    protected string _eventTitle = "Unkwown Title";
    protected string _description = "This is a description";
    protected string _date = "Unknown Date"; 
    protected string _time = "Unknown Time";
    protected Address _address;
    protected string _type = "Type of Event";

    public Event(string title, string description, string date, string time, Address address, string type)
    {
       _eventTitle = title;
       _description = description;
       _date = date; 
       _time = time;
       _address = address;
       _type = type; 
    }

    public abstract void StandardDetails();
    public abstract void FullDetails();
    public abstract void ShortDetails();
}