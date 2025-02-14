public class Program
{
    public static void Main()
    {
        GoalManager manager = new GoalManager();

        // Criação de metas
        Goal goal1 = new SimpleGoal("Run a Marathon", 1000);
        Goal goal2 = new EternalGoal("Read Scriptures", 100);
        Goal goal3 = new ChecklistGoal("Attend the Temple", 50, 10, 500);

        manager.AddGoal(goal1);
        manager.AddGoal(goal2);
        manager.AddGoal(goal3);

        // Exibir metas e pontuação
        manager.DisplayGoals();

        // Registrar evento
        manager.RecordGoalEvent(0); // Exemplo de registrar um evento para o primeiro objetivo
        manager.RecordGoalEvent(2); // Registrar evento para o terceiro objetivo

        // Exibir metas e pontuação após registrar eventos
        manager.DisplayGoals();
    }
}
