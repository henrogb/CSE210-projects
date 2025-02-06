public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "Who are the people you appreciate?",
        "What are your personal strengths?",
        "Who are the people you helped this week?"
    };

    public ListingActivity() : base("This activity will help you reflect on the good things in your life.")
    {
    }

    public void RunListingExercise()
    {
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine(prompt);
        Thread.Sleep(2000);

        Console.WriteLine("List as many things as you can...");
        Thread.Sleep(5000);
    }
}
