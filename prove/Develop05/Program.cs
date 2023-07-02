using System;
using System.Diagnostics;

namespace Develop05
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleGoal simpleGoal = new SimpleGoal();
            EternalGoal eternalGoal = new EternalGoal();
            CheckListGoal checklistGoal = new CheckListGoal();

            int totalScore = simpleGoal.GetUserScore() + eternalGoal.GetUserScore() + checklistGoal.GetUserScore();
            int userChoice = 0;

            do
            {
                Console.WriteLine();
                Console.WriteLine($"You have {totalScore} points");
                Console.WriteLine("Menu options: \n" +
                                  "1. Create new goal\n" +
                                  "2. List Goals\n" +
                                  "3. Record event\n" +
                                  "4. Quit\n");
                Console.WriteLine("Select a choice from the menu(coresponding number)");
                userChoice = int.Parse(Console.ReadLine());
                if (userChoice == 4)
                {
                    break;
                }


                Console.WriteLine("Simple goal, eternal goal, or checklist goal?");
                string goalType = Console.ReadLine().ToLower();

                Console.WriteLine("Name of your goal (Just enter a space if you're choosing option 2):");
                string goalName = Console.ReadLine();
                Console.WriteLine("Points of the goal (Just enter 0 if you're choosing option 2):");
                int goalPoint = int.Parse(Console.ReadLine());
                switch (userChoice)
                {
                    case 1:

                        if (goalType == "simple goal")
                        {
                            simpleGoal.CreateNewGoal(goalName, goalPoint);
                        }
                        else if (goalType == "eternal goal")
                        {
                            eternalGoal.CreateNewGoal(goalName, goalPoint);
                        }
                        else if (goalType == "checklist goal")
                        {
                            checklistGoal.CreateNewGoal(goalName, goalPoint);
                        }
                        else
                        {
                            Console.WriteLine("Please type in one of the three provided goal type:");
                        }
                        Console.WriteLine($"{goalType}: {goalName} is creted with {goalPoint} points reward");
                        break;
                    case 2:
                        if (goalType == "simple goal")
                        {
                            simpleGoal.DisplayGoal();
                        }
                        else if (goalType == "eternal goal")
                        {
                            eternalGoal.DisplayGoal();
                        }
                        else if (goalType == "checklist goal")
                        {
                            checklistGoal.DisplayGoal();
                        }
                        else
                        {
                            Console.WriteLine("Please type in one of the three provided goal type:");
                        }
                        break;
                    case 3:
                        if (goalType == "simple goal")
                        {
                            if (simpleGoal.CheckGoalList(goalName, goalPoint))
                            {
                                simpleGoal.RecordEvent(goalName, goalPoint);
                            }
                            else
                            {
                                break;
                            }
                        }
                        else if (goalType == "eternal goal")
                        {
                            if (eternalGoal.CheckGoalList(goalName, goalPoint))
                            {
                                eternalGoal.RecordEvent(goalName, goalPoint);
                            }
                            else
                            {
                                break;
                            }
                        }
                        else if (goalType == "checklist goal")
                        {
                            if (checklistGoal.CheckGoalList(goalName, goalPoint))
                            {
                                checklistGoal.RecordEvent(goalName, goalPoint);
                            }
                            else
                            {
                                break;
                            }
                        }
                        else
                        {
                            Console.WriteLine("Please type in one of the three ptovided goal type:");
                        }
                        Console.WriteLine($"{goalType}: {goalName} is recorded");
                        break;
                }
            } while (userChoice != 4);
        }
    }
}