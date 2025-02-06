public class BreathingActivity : Activity
{
    public BreathingActivity() : base("This activity will help you relax by walking through slow inhalation and exhalation.")
    {
    }

    public void RunBreathingExercise()
    {
        for (int i = 0; i < duration; i++)
        {
            Console.WriteLine("Inhale...");
            Thread.Sleep(2000);
            Console.WriteLine("Exhale...");
            Thread.Sleep(2000);
        }
    }
}
