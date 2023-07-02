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
        public override Dictionary<(string, int), int> DisplayGoal()
        {
            return _goalList;                

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
        public CheckListGoal() : base()
        {
            _goalList = new Dictionary<(string, int), int>();
        }
    }
}