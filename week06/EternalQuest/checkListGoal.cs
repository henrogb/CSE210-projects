public class ChecklistGoal : Goal
{
    public int TimesCompleted { get; private set; }
    public int Target { get; set; }
    public int BonusPoints { get; set; }

    public ChecklistGoal(string name, int points, int target, int bonusPoints) : base(name, points)
    {
        Target = target;
        BonusPoints = bonusPoints;
        TimesCompleted = 0;
    }

    public override void RecordEvent()
    {
        TimesCompleted++;
        int totalPoints = Points;
        if (TimesCompleted == Target)
        {
            totalPoints += BonusPoints;
            IsComplete = true;
            Console.WriteLine($"Goal completed! You earned an additional {BonusPoints} points.");
        }
        else
        {
            Console.WriteLine($"You completed {TimesCompleted}/{Target} for the goal: {Name}.");
        }
        Console.WriteLine($"You earned {totalPoints} points for this event.");
    }

    public override string GetDetailsString()
    {
        return IsComplete ? $"[X] {Name} - Completed {TimesCompleted}/{Target} times (Bonus: {BonusPoints} points)" : $"[ ] {Name} - Completed {TimesCompleted}/{Target} times";
    }
}
