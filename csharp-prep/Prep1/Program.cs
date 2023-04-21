using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your first name?");
        string f_Name = Console.ReadLine();

        Console.Write("What is your last name?");
        string l_Name = Console.ReadLine();

        Console.WriteLine($"Your name is {f_Name}, {f_Name} {l_Name}.");
    }
}