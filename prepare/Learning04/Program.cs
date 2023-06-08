using System;

namespace Learning04
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a base "Assignment" object
            Assignment assignment1 = new Assignment("Seth Chen", "Polynomial");
            Console.WriteLine(assignment1.GetSummary());

            // Now create the derived class assignments
            MathAssignment assignment2 = new MathAssignment("Nini Chen", "Binomial", "3.2", "1-5");
            Console.WriteLine(assignment2.GetSummary());
            Console.WriteLine(assignment2.GetHomeworkList());

            WritingAssignment assignment3 = new WritingAssignment("Lenny", "American Heritage", "The economy of the early America");
            Console.WriteLine(assignment3.GetSummary());
            Console.WriteLine(assignment3.GetWritingInformation());
        }
    }
}