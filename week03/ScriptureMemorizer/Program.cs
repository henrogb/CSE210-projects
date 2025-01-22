using System;
using System.Collections.Generic;
using System.Linq;

public class Reference
{
    public string Text { get; set; }

    public Reference(string text)
    {
        Text = text;
    }

    // Additional constructor to handle range of verses
    public Reference(string book, int startVerse, int endVerse)
    {
        Text = $"{book} {startVerse}-{endVerse}";
    }
}

public class Word
{
    public string OriginalText { get; set; }
    public string HiddenText { get; set; }

    public Word(string text)
    {
        OriginalText = text;
        HiddenText = new string('_', text.Length);  // Initializes with underscores
    }

    public void Hide()
    {
        HiddenText = new string('_', OriginalText.Length);
    }
}

public class Scripture
{
    public Reference Reference { get; set; }
    public List<Word> Words { get; set; }

    public Scripture(string reference, string text)
    {
        Reference = new Reference(reference);
        Words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    // Displays the scripture, with hidden or visible words
    public void Display()
    {
        Console.Clear();
        Console.WriteLine(Reference.Text);
        Console.WriteLine(string.Join(" ", Words.Select(w => w.HiddenText)));
    }

    // Hides a random word
    public void HideRandomWord()
    {
        var nonHiddenWords = Words.Where(w => w.HiddenText != w.OriginalText).ToList();
        if (nonHiddenWords.Count > 0)
        {
            var randomWord = nonHiddenWords[new Random().Next(nonHiddenWords.Count)];
            randomWord.Hide();
        }
    }

    // Checks if all words are hidden
    public bool AllHidden()
    {
        return Words.All(w => w.HiddenText == w.OriginalText);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        var scriptureText = "For God so loved the world that he gave his only begotten Son, that whoever believes in him should not perish, but have eternal life";
        var reference = "John 3:16";
        var scripture = new Scripture(reference, scriptureText);

        Console.WriteLine("Press Enter to start memorizing or type 'quit' to exit.");
        
        string command = Console.ReadLine();
        while (command.ToLower() != "quit" && !scripture.AllHidden())
        {
            scripture.Display();
            command = Console.ReadLine();

            if (command.ToLower() != "quit")
            {
                scripture.HideRandomWord();
            }
        }

        if (scripture.AllHidden())
        {
            Console.Clear();
            Console.WriteLine("Congratulations! You have memorized the scripture!");
        }
    }
}
