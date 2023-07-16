public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, double minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    public override double Distance()
    {
        return _distance;
    }

    public override double Speed()
    {
        double _speedInKm = (_distance / _minutes) * 60;
        return _speedInKm;
    }

    public override double Pace()
    {
        double _paceInMn = 60 / Speed();
        return _paceInMn;
    }

    public override void GetSummary()
    {
        Console.WriteLine(
            $"{_date} Running ({_minutes} min)- {_distance} km, Speed {Speed()} kmh, Pace: {Pace()} min per km"
        );
    }
}
