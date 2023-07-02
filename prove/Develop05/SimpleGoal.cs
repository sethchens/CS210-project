using System;

namespace Develop05
{
    public class SimpleGoal : Goal<string>
    {

        public override void CreateNewGoal(string goalName, int goalPoint)
        {
            base._goalList.Add((goalName, goalPoint), "[]");
        }
        public override void DisplayGoal()
        {
            if (_goalList.Count == 0)
            {
                Console.WriteLine("There is nothing in the goal list currently");
            }
            else
            {
                foreach (KeyValuePair<(string, int), string> item in _goalList)
                {
                    Console.WriteLine(item.Key);
                }
            }

        }
        public override int DisplayUserScore()
        {
            return base.GetUserScore();
        }
        public override bool IsComplete(string goalName, int goalPoint)
        {
            if (_goalList[(goalName, goalPoint)] == "[]")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public override int RecordEvent(string goalName, int goalPoint)
        {
            _goalList[(goalName, goalPoint)] = "[x]";
            (string, int) key = (goalName, goalPoint);
            base.SetUserScore(goalPoint);
            return key.Item2; // item2 is a built-in method to get the second value of the key if there is any
        }
        public override bool CheckGoalList(string goalName, int goalPoint)
        {
            if ((_goalList.ContainsKey((goalName, goalPoint))))
            {
                return true;
            }
            else
            {
                Console.WriteLine("The goal is not contains in the current goal list");
                return false;
            }
        }

        public SimpleGoal() : base()
        {
            _goalList = new Dictionary<(string, int), string>();
        }
    }
}