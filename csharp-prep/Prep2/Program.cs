using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your grade percentage?");
        string percent = Console.ReadLine();
        int percentage = int.Parse(percent);
        string letter;

        if (percentage >= 90)
        {
            if (percentage < 93)
            {
                letter = "A-";
            }
            else
            {
                letter = "A";
            }
        }
        else if (percentage >= 80 && percentage < 90)
        {
            if (percentage >= 87)
            {
                letter = "B+";
            }
            else if (percentage < 83)
            {
                letter = "B-";
            }
            else
            {
                letter = "B";
            }
        }
        else if (percentage >= 70 && percentage < 80)
        {
            if (percentage >= 77)
            {
                letter = "C+";
            }
            else if (percentage < 73)
            {
                letter = "C-";
            }
            else
            {
                letter = "C";
            }
        }
        else if (percentage >= 60 && percentage <70)
        {
            if (percentage >= 67)
            {
                letter = "D+";
            }
            else if (percentage < 63)
            {
                letter = "D-";
            }
            else
            {
                letter = "D";
            }
        }
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}.");

        if (letter == "A" || letter == "B" || letter == "C")
        {
            Console.WriteLine("Congratulation! You passed the course.");
        }
        else
        {
            Console.WriteLine("Oops, looks like you have to retake the course.");
        }
    }
}