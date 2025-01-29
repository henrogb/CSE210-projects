using System;
using System.Collections.Generic;

public class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Duration { get; set; } // duração em segundos
    public List<Comment> Comments { get; set; }

    // Construtor da classe Video
    public Video(string title, string author, int duration)
    {
        Title = title;
        Author = author;
        Duration = duration;
        Comments = new List<Comment>(); // Inicializando a lista de comentários
    }

    // Método para retornar o número de comentários
    public int GetCommentCount()
    {
        return Comments.Count;
    }

    // Método para exibir informações do vídeo e os comentários
    public void DisplayVideoInfo()
    {
        Console.WriteLine($"Title: {Title}\nAuthor: {Author}\nDuration: {Duration} seconds\nNumber of comments: {GetCommentCount()}\n");
        foreach (var comment in Comments)
        {
            comment.DisplayComment();
        }
    }
}
