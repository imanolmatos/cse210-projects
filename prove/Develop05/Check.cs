public class Checklist : Goals
{
    private int _bonus = 0;
    private int _target = 0;
    private int _timesCompleted = 0;

    public Checklist(
        string name,
        string description,
        int points,
        bool isCompleted,
        int timesCompleted,
        int target,
        int bonusPoints
    )
        : base(name, description, points, isCompleted) 
        { 
            
        _bonus = bonusPoints;
        _target = target;
        _timesCompleted = timesCompleted;           
        }

    public override int RecordEvent()
    {
        Console.WriteLine("How many times have you completed the goal? ");
        int _amountOfTimes = int.Parse(Console.ReadLine());
        _timesCompleted = _timesCompleted + _amountOfTimes;
        if (_timesCompleted >= _target)
        {
            _isCompleted = true;
            Console.WriteLine("");
            return (_points * _amountOfTimes) + _bonus;
        }
        else
        {
            Console.WriteLine("");
            return _points * _amountOfTimes;
        }
    }

    public override string SaveString()
    {
        return $"Checklist~{_name}~{_description}~{_points}~{_isCompleted}~{_bonus},{_target}~{_timesCompleted}";
    }
}
