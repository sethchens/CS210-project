using System;

namespace Develop05 {
    public class EternalGoal : Goal<int> {
        public override void CreateNewGoal(string goalName, int goalPoint)
        {
            _goalList.Add((goalName, goalPoint), 0);
        }
        public override Dictionary<(string, int), int> DisplayGoal()
        {
            return _goalList;
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
        public EternalGoal() : base() {
            _goalList = new Dictionary<(string, int), int>();
        }
    }
}