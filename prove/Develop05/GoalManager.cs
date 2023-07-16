public class GoalManager
{
    private List<Goals> _goalsList = new List<Goals>();
    private int _totalPoints = 0;
    public void SaveToFile()
    {
        Console.WriteLine("What is the name of your file? ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_totalPoints);
            foreach (Goals goal in _goalsList)
            {
                outputFile.WriteLine(goal.SaveString());
            }
        }
    }

    public int TotalAmountPoints()
    {
        return _totalPoints;
    }

    public void ReducePoints(int reduce)
    {
        _totalPoints = _totalPoints - reduce;
    }
    public void AddGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.WriteLine("0. Return to Menu");
        Console.WriteLine("Which type of goal would you like to create?");
        int _typeOfGoal = int.Parse(Console.ReadLine());

        if (_typeOfGoal != 0)
        {
            Console.WriteLine("What is the name of your Goal? ");
            string _nameOfGoal = Console.ReadLine();
            Console.WriteLine("What is a short Description of it? ");
            string _shortDescription = Console.ReadLine();
            Console.WriteLine("What is the amount of points associated with this goal? ");
            int _amountOfPoints = int.Parse(Console.ReadLine());
            if (_typeOfGoal == 1)
            {
                Simple goal = new Simple(_nameOfGoal, _shortDescription, _amountOfPoints, false);
                _goalsList.Add(goal);
            }
            else if (_typeOfGoal == 2)
            {
                Eternal goal = new Eternal(_nameOfGoal, _shortDescription, _amountOfPoints, false);
                _goalsList.Add(goal);
            }
            else
            {
                Console.WriteLine("What is the target amount of times to complete this goal? ");
                int _target = int.Parse(Console.ReadLine());
                Console.WriteLine("What is the amount of bonus points? ");
                int _bonusPoints = int.Parse(Console.ReadLine());
                Checklist goal = new Checklist(
                    _nameOfGoal,
                    _shortDescription,
                    _amountOfPoints,
                    false,
                    0,
                    _target,
                    _bonusPoints
                );
                _goalsList.Add(goal);
            }
        }
    }

    public void LoadFromFile()
    {
        _goalsList.Clear();
        Console.WriteLine("What is the name of your file? ");
        string _fileName = Console.ReadLine();
        string _line1 = File.ReadLines(_fileName).First(); 
        int _first = int.Parse(_line1);
        _totalPoints = _first;
        string[] _lines = File.ReadAllLines(_fileName);
        
        foreach (string line in _lines)
        {   
            string[] _parts = line.Split("~");  
               
            if (_parts[0] == "Simple")
            {   string _name = _parts[1];
                string _description = _parts[2];
                int _points = int.Parse(_parts[3]);
                bool _complete = bool.Parse(_parts[4]);
                Simple goal = new Simple(_name, _description, _points, _complete);
                _goalsList.Add(goal);
            }
            else if (_parts[0] == "Checklist")
            {   string _name = _parts[1];
                string _description = _parts[2];
                int _points = int.Parse(_parts[3]);
                int _target = int.Parse(_parts[6]);
                int _bonus = int.Parse(_parts[7]);
                bool _complete = bool.Parse(_parts[4]);
                int _times = int.Parse(_parts[5]);
                Checklist goal = new Checklist(
                    _name,
                    _description,
                    _points,
                    _complete,
                    _times,
                    _target,
                    _bonus
                );
                _goalsList.Add(goal);
            }
            else if (_parts[0] == "Eternal")
            {
                 string _name = _parts[1];
                 string _description = _parts[2];
                 int _points = int.Parse(_parts[3]);
                Eternal goal = new Eternal(_name, _description, _points, false);
                _goalsList.Add(goal);
            }
        }
    }
    public void RecordEvent()
    {
        int counter = 1;
        foreach (Goals goal in _goalsList)
        {
            Console.Write($"{counter}. {goal.Display()}");
            counter += 1;
        }

        int number;
        do
        {
            Console.WriteLine("Enter goal number: ");
            number = int.Parse(Console.ReadLine());
        } while (_goalsList[number - 1].IsCompleted);

        _totalPoints += _goalsList[number - 1].RecordEvent();
    }

    public void PrincipalDisplay()
    {
          foreach (Goals goal in _goalsList)
        {          
           Console.Write(goal.Display());  
        }
    }
}
