using System;

namespace Develop04 {
    public class Activity {
        private int _duration;
        private static string _startMessage;
        private string _endMessage =
            "Hope you feel better for the day. You are more" +
            "than welcome to do the activity again.";

        public void SetStartMessage(string startMessage) {
            _startMessage = startMessage;
        }

        public void SetEndMessage(string endMessage) {
            _endMessage = endMessage;
        }

        public int GetDuration(int duration) {
            _duration = duration;
            return _duration;
        }

        public void StartMessage() {
            Console.WriteLine(_startMessage);
        }

        public void EndMessage() {
            Console.WriteLine(_endMessage);
        }

        public void CountDown() {
            Console.WriteLine("Pause for 3 seconds...");
            Thread.Sleep(500);
            Console.WriteLine("3");
            Thread.Sleep(1000);
            Console.WriteLine("2");
            Thread.Sleep(1000);
            Console.WriteLine("1");
            Thread.Sleep(1000);
            Console.WriteLine("Time's up! Get back on!");
        }

        // This constructor set the starting message differently 
        // based on the type of the activity
        public Activity(string activityType) {
            switch (activityType) {
                case "Breathing Activity":
                    _startMessage = 
                        "This activity will help you relax by " +
                        "walking your through breathing in and out " +
                        "slowly. Clear your mind and focus on your breathing.";
                    break;
                case "Reflection Activity":
                    _startMessage =
                        "This activity will help you reflect on times in " +
                        "your life when you have shown strength and " +
                        "resilience. This will help you recognize the " +
                        "power you have and how you can use it in other " +
                        "aspects of your life.";
                    break;
                case "Listing Activity":
                    _startMessage =
                       "This activity will help you reflect on the good " +
                       "things in your life by having you list as many " +
                       "things as you can in a certain area.";
                       break;
            }

        }
    }
}