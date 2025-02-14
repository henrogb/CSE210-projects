public class GoalManager
{
    private List<Goal> goals;
    private int totalScore;

    public GoalManager()
    {
        goals = new List<Goal>();
        totalScore = 0;
    }

    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }

    public void RecordGoalEvent(int goalIndex)
    {
        if (goalIndex >= 0 && goalIndex < goals.Count)
        {
            goals[goalIndex].RecordEvent();
            totalScore += goals[goalIndex].Points;
        }
        else
        {
            Console.WriteLine("Invalid goal index.");
        }
    }

    public void DisplayGoals()
    {
        foreach (var goal in goals)
        {
            Console.WriteLine(goal.GetDetailsString());
        }
        Console.WriteLine($"Total Score: {totalScore}");
    }
}

