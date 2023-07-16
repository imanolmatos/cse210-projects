public class SwimmingActivity : Activity
{
    private double _numberOfLaps;

    public SwimmingActivity(string date, double minutes, double numberOfLaps)
        : base(date, minutes)
    {
        _numberOfLaps = numberOfLaps;
    }

    public override double Distance()
    {
        double distanceKm = _numberOfLaps * 50 / 1000;
        return distanceKm;
    }
    public override double Speed()
    {
        double speedInKm = (Distance() / _minutes) * 60;
        return speedInKm;
    }

    public override double Pace() 
    { 
        double _pace = _minutes / Distance();
        return _pace;
    }

    public override void GetSummary()
    {
        Console.WriteLine($"{_date} Swimming ({_minutes} min)- {Distance()} km, Speed {Speed()} kmh, Pace: {Pace()} min per km");
    }
}
