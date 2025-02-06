public class ReflectingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really hard.",
        "Think of a time when you helped someone in need."
    };

    public ReflectingActivity() : base("This activity will help you reflect on moments in your life where you demonstrated strength and resilience.")
    {
    }

    public void RunReflectionExercise()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Thread.Sleep(2000);

        // Example question
        Console.WriteLine("Why was this experience meaningful to you?");
        Thread.Sleep(2000);
    }
}
