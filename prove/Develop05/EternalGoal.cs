using System;

namespace Develop05 {
    public class EternalGoal : Goal<int> {
        public override void CreateNewGoal(string goalName, int goalPoint)
        {
            _goalList.Add((goalName, goalPoint), 0);
        }
        public override void DisplayGoal()
        {
            if (_goalList.Count == 0)
            {
                Console.WriteLine("There is nothing in the goal list currently");
            }
            else
            {
                foreach (KeyValuePair<(string, int), int> item in _goalList)
                {
                    Console.WriteLine(item.Key);
                }
            }

        }
        public override int RecordEvent(string goalName, int goalPoint)
        {
            _goalList[(goalName, goalPoint)] += 1;
            base.SetUserScore(goalPoint);
            return goalPoint;
        }
        public override bool IsComplete(string goalName, int goalPoint)
        {
            if (_goalList[(goalName, goalPoint)] > 0)
            {
                Console.WriteLine("The goal has been done " +
                                  $"{_goalList[(goalName, goalPoint)]} time(s)");
                return true;
            }
            else
            {
                Console.WriteLine("The goal has not ever been done");
                return false;
            }
        }
        public override int DisplayUserScore()
        {
            return base.GetUserScore();
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
        public EternalGoal() : base() {
            _goalList = new Dictionary<(string, int), int>();
        }
    }
}