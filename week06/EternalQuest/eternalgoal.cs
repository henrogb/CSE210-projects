public class EternalGoal : Goal
{
    public EternalGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        Console.WriteLine($"You earned {Points} points for {Name}!");
    }

    public override string GetDetailsString()
    {
        return $"{Name} - {Points} points per event (Eternal Goal)";
    }
}
