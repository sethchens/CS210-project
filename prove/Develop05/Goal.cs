using System;

namespace Develop05 {
    public abstract class Goal<T> {
        private int _userScore = 0;
        protected Dictionary<(string, int), T> _goalList;

        public Dictionary<(string, int), T> GetGoalList() {
            return _goalList;
        }
        public abstract bool CheckGoalList(string goalName, int goalPoint);
        public int GetUserScore() {
            return _userScore;
        }
        public void SetUserScore(int score) {
            _userScore = score;
        }

        public abstract void CreateNewGoal(string goalName, int goalPoint);
        public abstract void DisplayGoal();
        public abstract int RecordEvent(string goalName, int goalPoint);
        public abstract bool IsComplete(string goalName, int goalPoint);
        public abstract int DisplayUserScore();
    }
}