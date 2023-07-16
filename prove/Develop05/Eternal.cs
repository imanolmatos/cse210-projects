public class Eternal : Goals
{
    public Eternal(string name, string description, int points, bool isCompleted)
        : base(name, description, points, isCompleted) { }

    public override int RecordEvent()
    {
        _isCompleted = false; //this will never be completed
        Console.WriteLine("");
        return _points;
    }

    public override string SaveString()
    {
        return $"Eternal~{_name}~{_description}~{_points}";
    }
}
