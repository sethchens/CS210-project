using System;

namespace Develop05 {
    public class SimpleGoal : Goal<string> {

        public override void CreateNewGoal(string goalName, int goalPoint)
        {
            base._goalList.Add((goalName, goalPoint), "[]");
        }
        public override Dictionary<(string, int), string> DisplayGoal() {
            return _goalList;
        }
        public override int DisplayUserScore()
        {
            return base.GetUserScore();
        }
        public override bool IsComplete(string goalName, int goalPoint)
        {
            if (_goalList[(goalName, goalPoint)] == "[]"){
                return false;
            }
            else {
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

        public SimpleGoal() : base() {
            _goalList = new Dictionary<(string, int), string>();
        }
    }
}