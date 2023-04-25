using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        Console.WriteLine(userName);

        int number = PromptuserNumber();
        Console.WriteLine(number);

        int square = SquareNumber(number);
        DisplayResult(userName, number);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name:");
        string username = Console.ReadLine();
        return username;
    }

    static int PromptuserNumber()
    {
        Console.Write("What is your favorite number?");
        int num = int.Parse(Console.ReadLine());
        return num;
    }

     static int SquareNumber(int number)
     {
        int squareNumber = number * number;
        return squareNumber;
     }

     static void DisplayResult(string userName, int square)
     {
        Console.WriteLine($"{userName}, the square of your number is {square}.");
     }
}