using System;

namespace Develop04 {
    public class BreathingActivity : Activity{

        public void BreathPrompt() {
                Console.WriteLine("Breath in");
                base.CountDown();
                Console.WriteLine("Breath out");
                base.CountDown();
        }

        public BreathingActivity() : base("Breathing Activity"){
            //This would just change the start message
        }
    }
}