public class Video
{
    private string _title = "unknown";
    private string _author = "unknown";
    private int _lengthSeconds = 0;
    public List<Comment> comments = new List<Comment>();
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _lengthSeconds = length;
    }

    public void NumOfComments()
    {
        int num = comments.Count();
        Console.WriteLine($"The number of comments is {num}");
    }

    public void Display()
    {   Console.WriteLine();
        Console.WriteLine($"Title: {_title} ~ Author: {_author} ~ Duration: {_lengthSeconds}");
        foreach (Comment comment in comments)
        {
            comment.Display();
        }
    }
}
