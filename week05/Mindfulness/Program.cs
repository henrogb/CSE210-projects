public class Activity
{
    protected int duration; // duration of the activity
    protected string description; // description of the activity

    public Activity(string description)
    {
        this.description = description;
    }

    public void Start()
    {
        ShowStartingMessage();
        PauseForPreparation();
    }

    protected void ShowStartingMessage()
    {
        Console.WriteLine(description);
        Console.WriteLine("Set the duration of the activity in seconds: ");
        duration = int.Parse(Console.ReadLine());
    }

    protected void PauseForPreparation()
    {
        Console.WriteLine("Preparing...");
        Thread.Sleep(2000); // 2-second pause
    }

    public void End()
    {
        Console.WriteLine("Congratulations, you completed the activity!");
    }
}
