public class SimpleGoal : Goal
{
    public SimpleGoal(string name, int points) : base(name, points) { }

    public override void RecordEvent()
    {
        IsComplete = true;
        Console.WriteLine($"You completed the goal: {Name} and earned {Points} points!");
    }

    public override string GetDetailsString()
    {
        return IsComplete ? $"[X] {Name} - {Points} points" : $"[ ] {Name} - {Points} points";
    }
}
