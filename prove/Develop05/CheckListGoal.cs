using System;

namespace Develop05
{
    public class CheckListGoal : Goal<int>
    {
        public override void CreateNewGoal(string goalName, int goalPoint)
        {
            // Set the default number of time of achievement as 0
            // but the number of goal is 5
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
            if (_goalList[(goalName, goalPoint)] < 5)
            {
                _goalList[(goalName, goalPoint)] += 1;
                base.SetUserScore(goalPoint);
                // bonus logic, add 5 extra points when achieve 5 times
                if (_goalList[(goalName, goalPoint)] == 5)
                {
                    _goalList[(goalName, goalPoint)] += 5;
                }
            }
            return goalPoint;
        }
        public override bool IsComplete(string goalName, int goalPoint)
        {
            if (_goalList[(goalName, goalPoint)] != 5)
            {
                Console.WriteLine($"{goalName} has been completed " +
                                $"{_goalList[(goalName, goalPoint)]}/5 time(s)");
                return false;
            }
            else
            {
                return true;
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
        public CheckListGoal() : base()
        {
            _goalList = new Dictionary<(string, int), int>();
        }
    }
}