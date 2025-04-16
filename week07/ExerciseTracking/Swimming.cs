public class Swimming : Activity
{
    public int Laps { get; set; } 

    public override double GetDistance()
    {
        return Laps * 50 / 1000.0; 
    }

    public override double GetSpeed()
    {
        return (GetDistance() / Duration) * 60; 
    }

    public override double GetPace()
    {
        return Duration / GetDistance(); 
    }
}
