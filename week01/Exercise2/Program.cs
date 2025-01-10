using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine("What is your grade?");
        
        
        string userInput = Console.ReadLine(); 
        float userGrade = float.Parse(userInput);

        
        string letter = "";

        
        if (userGrade >= 90)
        {
            letter = "A";
        }
        else if (userGrade >= 80)
        {
            letter = "B";
        }
        else if (userGrade >= 70)
        {
            letter = "C";
        }
        else if (userGrade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        
        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine($"Your final grade is {letter}, congratulations you passed, keep it up.");
        }
        else
        {
            Console.WriteLine($"Your final grade is {letter}, unfortunately you didn't pass but keep trying hard and you can do it.");
        }
    }
}
