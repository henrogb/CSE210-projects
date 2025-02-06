public void ShowSpinner()
{
    string[] spinner = new string[] { "|", "/", "-", "\\" };
    int count = 0;

    for (int i = 0; i < 10; i++)
    {
        Console.Write(spinner[count % 4]);
        Thread.Sleep(500);
        Console.Write("\b \b");
        count++;
    }
}
