public class Comment
{
    private string _nameOfPerson = "Unknown";
    private string _comment = "<<Comment Information>>";
    public Comment(string name, string comment)
    {
        _nameOfPerson = name;
        _comment = comment;
    }
    public void Display()
    {
        Console.WriteLine($"Name of person: {_nameOfPerson} ~ Comment: {_comment}");
    }
}
