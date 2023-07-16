public class BikeActivity : Activity
{
    private double _speed;

    public BikeActivity(string date,  double minutes, double speed)
        : base(date, minutes)
    {
        _speed = speed;
    }

    public override double Distance() 
    {double _distanceInKm = _speed * _minutes / 60;
    return _distanceInKm;

    }

    public override double Speed() 
    {
    return _speed;
    }

    public override double Pace() 
    { 
        double _paceInMn = 60 / _speed;
        return _paceInMn;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date} Biking ({_minutes} min)- {Distance()} km, Speed {Speed()} kmh, Pace: {Pace()} min per km");
    }
}
