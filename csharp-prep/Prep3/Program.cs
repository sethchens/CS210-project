using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Create an instance for random num and sotre it to 'randomNum'.
        Random random = new Random();
        int randomNum = random.Next(1, 101);

        int guess = -1;
        List<int> guessedNums = new List<int>();
        string answer = "y";

        while (answer == "y") {
            do {
                Console.WriteLine("What is your guess?");
                guess = int.Parse(Console.ReadLine());
                guessedNums.Add(guess);

                if (guess < randomNum) {
                    Console.WriteLine("Higher!");
                } else if (guess > randomNum) {
                    Console.WriteLine("Lower!");
                } else {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"Your guessed numbers is {guessedNums}");
                }
            } while (guess != randomNum);
            Console.WriteLine("Do you Want to play again?(y/n)");
            answer = Console.ReadLine();
        }
    }
}