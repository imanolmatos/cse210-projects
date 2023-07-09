public class Simple : Goals
{
    public Simple(string name, string description, int points, bool isCompleted)
        : base(name, description, points, isCompleted) { }

    public override int RecordEvent()
    {
        _isCompleted = true;
        Console.WriteLine($"Congratulations, you have earned {_points}! ");
        return _points;
    }
    // return points


    public override string SaveString()
    {
        return $"Simple,{_name},{_description},{_points},{_isCompleted}";
    }
}
