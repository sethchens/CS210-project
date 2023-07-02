using System;

namespace Develop05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("You have 0 points");
            Console.WriteLine("Menu options:" +
                              "1. Create new goal" +
                              "2. List Goals" +
                              "3. Load goals" +
                              "4. Record event" +
                              "5. Quit");
            Console.WriteLine("Select a choice from the menu");
            int userChoice = int.Parse(Console.ReadLine());
            switch (userChoice) {
                case 1:
                    Console.WriteLine("Simple goal, eternal goal, or checklist goal?");
                    string goalType = Console.ReadLine().ToLower();

                    Console.WriteLine("Name of your goal:");
                    string goalName = Console.ReadLine();
                    Console.WriteLine("Points of the goal:");
                    int goalPoint = int.Parse(Console.ReadLine());

                    if (goalType == "simple goal")
                    {
                        SimpleGoal simpleGoal = new SimpleGoal();
                        simpleGoal.CreateNewGoal(goalName, goalPoint);
                    }
                    else if (goalType == "Eternal goal")
                    {
                        EternalGoal eternalGoal = new EternalGoal();
                        eternalGoal.CreateNewGoal(goalName, goalPoint);
                    }
                    else if (goalType == "checklist goal")
                    {
                        CheckListGoal checklistGoal = new CheckListGoal();
                        checklistGoal.CreateNewGoal(goalName, goalPoint);
                    }
                    break;
            }
        }
    }
}