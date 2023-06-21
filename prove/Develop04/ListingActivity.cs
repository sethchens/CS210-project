using System;

namespace Develop04 {
    public class ListingActivity : Activity {
        private List<string> _userAnswer = new List<string>();
        private List<string> _thinkingTopicList = new List<string>
        {"Who are people that you appreciate?",
         "What are personal strengths of yours?", 
         "Who are people that you have helped this week?",
         "When have you felt the Holy Ghost this month?",
         "Who are some of your personal heroes?"
        };

        public void PromptThinkingTopic() {
            Random random = new Random();
            int randomNumber = random.Next(0, 4);
            Console.WriteLine(_thinkingTopicList[randomNumber]);
            base.CountDown();
        }

        public void StoreUserAnswer(string userAnswer) {
            _userAnswer.Add(userAnswer);
        }

        public void DisplayNumberOfUserAnswer() {
            int count = 0;
            foreach (string answer in _userAnswer) {
                count += 1;
            }
            Console.WriteLine($"You have entered {count} answers");
        }

        public ListingActivity() : base("Listing Activity") {
            //This would just change the start message
        }
    }
}