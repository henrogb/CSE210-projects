using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        // Criando vídeos e adicionando comentários
        var video1 = new Video("How to Program in C#", "John Silva", 300);
        video1.Comments.Add(new Comment("Maria", "Great video! Learned a lot."));
        video1.Comments.Add(new Comment("Carlos", "Very good, but it could be more detailed."));
        video1.Comments.Add(new Comment("Ana", "Great content, thanks!"));

        var video2 = new Video("Learning Python", "Fernanda Costa", 250);
        video2.Comments.Add(new Comment("Pedro", "Loved the explanation, very clear!"));
        video2.Comments.Add(new Comment("Lucas", "Very good, but it would be nice to see a practical example."));
        video2.Comments.Add(new Comment("Sofia", "Perfect video for beginners."));

        var video3 = new Video("Introduction to Java", "Ricardo Lima", 200);
        video3.Comments.Add(new Comment("Carlos", "Well explained content, but the audio could be better."));
        video3.Comments.Add(new Comment("Juliana", "Good explanation!"));
        
        // Criando uma lista de vídeos
        List<Video> videos = new List<Video> { video1, video2, video3 };

        // Iterando pelos vídeos e exibindo informações
        foreach (var video in videos)
        {
            video.DisplayVideoInfo();
            Console.WriteLine("--------------------------");
        }
    }
}
