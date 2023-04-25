using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numList = new List<int>();
        int num;
        int total;
        double average;
        int largest = 0;

        Console.WriteLine("Enter a list of numbers; Tyoe 0 when finish.");

        do {
            num = int.Parse(Console.ReadLine());
            numList.Add(num);
            total = numList.Sum();

            //Calculate the average but exclude the count of 0 
            //to get the correct average number.

            if (numList.Count != 1) {
                average = total / (numList.Count - 1);
            } else {
                average = 0;
            }
            
            if (num > largest) {
                largest = num;
            }
        } while (num != 0);

        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"THe average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}