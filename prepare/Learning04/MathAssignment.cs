

public class MathAssignment : Assignment
{
    private string _problems;
    private string _textbook;
   

    public MathAssignment(string studentName, string topic, string textbook,string problems) : base(studentName, topic)
    {
    _problems = problems;
    _textbook = textbook;
    }

    public string GetHomeworkList()
    {

        return $"{_textbook} {_problems}";
    }

    


    

}