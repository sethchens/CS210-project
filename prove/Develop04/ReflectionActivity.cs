using System;

namespace Develop04 {
    public class ReflectionActivity : Activity {
        private List<string> _randomPromptAnswer = new List<string>();
        private List<string> _reflectOnAnswer = new List<string>();
        private List<string> randomPromptList = new List<string> 
        {
         "Think of a time when you stood up for someone else.",
         "Think of a time when you did something really difficult.",
         "Think of a time when you helped someone in need.",
         "Think of a time when you did something truly selfless."
        };

        private List<string> reflectOnPromptList = new List<string>
        {
         "Why was this experience meaningful to you?",
         "Have you ever done anything like this before?",
         "How did you get started?",
         "How did you feel when it was complete?",
         "What made this time different than other times when " +
         "you were not as successful?",
         "What is your favorite thing about this experience?",
         "What could you learn from this experience that applies " +
         "to other situations?",
         "What did you learn about yourself through this experience?",
         "How can you keep this experience in mind in the future?"
        };

        public void PromptRandomPrompt() {
            Random random = new Random();
            int randomNumber = random.Next(0, 3);
            Console.WriteLine(randomPromptList[randomNumber]);
            Spinner(3);
        }

        public void PromptReflectOnPrompt() {
            Random random = new Random();
            int randomNumber = random.Next(0, 8);
            Console.WriteLine(reflectOnPromptList[randomNumber]);
            Spinner(3);
        }

        public void StoreRandomPromptAnswer(string userAnswer) {
            _randomPromptAnswer.Add(userAnswer);
        }

        public void StoreReflectOnAnswer(string userAnswer) {
            _reflectOnAnswer.Add(userAnswer);
        }

        public void Spinner(int duration) {
            // If this code were in a loop it
            // would continue displaying and replacing characters
            for (int i = 0; i < duration; i ++) {
                Console.Write("+");
                Thread.Sleep(500);
                Console.Write("\b \b"); // Erase the + character
                Thread.Sleep(500);
                Console.Write("-"); // Replace it with the - character
                Thread.Sleep(500);
                Console.Write("\b \b"); // Erase the + character
            }
        }

        public ReflectionActivity() : base("Reflection Activity") {
            //This would just change the start message
        }
    }
}