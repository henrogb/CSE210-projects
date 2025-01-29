public class Comment
{
    public string Author { get; set; }
    public string Text { get; set; }

    // Construtor da classe Comment
    public Comment(string author, string text)
    {
        Author = author;
        Text = text;
    }

    // Método para exibir o comentário
    public void DisplayComment()
    {
        Console.WriteLine($"Commented by: {Author}\nText: {Text}\n");
    }
}
