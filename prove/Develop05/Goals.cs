public Goals
{
    private int _points;
    private string _description;
    private bool _isNotCompleted = false;
    private string _name;


    public Goals(string name, string description, string points)
    {_points = points;
    _description = description;
    _name = name;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }


    public void SetPoints()
    {
    }

    public int GetPoints()
    {
        return _points;
    }
    public bool IsCompleted
    {
        return _isCompleted;
    }
    public void Selection() 
    {Console.WriteLine("The types of Goals are:")
    Console.WriteLine("1. Simple Goal");
    Console.WriteLine("2. Eternal Goal");
    Console.WriteLine("3. Checklist Goal");
    Console.WriteLine("Which type of goal would you like to create?");
    string _typeOfGoal = Console.Read();
    int _chooseGoal = int.Parse(_typeOfGoal);
    Console.WriteLine("What is the name of your Goal? ");
    _nameOfGoal = Console.ReadLine();
    Console.WriteLine("What is a short Description of it? ")
    _shortDescription = Console.Read();
    Console.WriteLine("What is the amount of points associated with this goal? ");
    _amountOfPointsString = Console.ReadLine();
    _points = int.Parse(_amountOfPointsString);
    Console.WriteLine("How many times does this goal need to be accomplished for a bonus? ")
    _amountOfTimeString = Console.ReadLine();
    _aountOfPoints = int.Parse(_amountOfPointsString);
    Console.WriteLine("What is the bonus for accomplishing it that many times? ")
    _bonusString = Console.ReadLine();
    _bonus = int.Parse(_bonusString)

    }

    public void ListGoals()
    {   Console.WriteLine("The goals are");
        Console.WriteLine("{[ ] listElement}");
        ShowPoints();
    }

    public void ShowPoints() 
    {
        Console.WriteLine($"You got {_points} points")

    }

    public char Complete()
    {
        if (_isNotCompleted) 
        {
            char mark = " ";
            return mark;
        }

        else if (_isNotCompleted)
        {
            char mark = "X";
            return mark;
        }
        
    }

    Public abstract Complete(){}
    public abstract SaveGoal(){}
    public abstract LoadGoal(){}
}