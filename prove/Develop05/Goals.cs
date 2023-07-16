public abstract class Goals
{
    protected int _points;
    protected string _description;
    protected string _name;
    protected bool _isCompleted = false;
    public bool IsCompleted
    {
        get { return _isCompleted; }
    }

    public Goals(string name, string description, int points, bool isCompleted)
    {
        _points = points;
        _description = description;
        _name = name;
        _isCompleted = isCompleted;
    }

    public void ShowPoints()
    {
        Console.WriteLine($"You got {_points} points");
    }

    private char Complete()
    {
        if (!_isCompleted)
        {
            return ' ';
        }
        else
        {
            return 'X';
        }
    }

    public string Display()
    {
        return $"[{Complete()}] {_name} {_description}\n";
    }

    public abstract int RecordEvent();
    public abstract string SaveString();
}
