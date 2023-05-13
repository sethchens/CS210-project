using System;
using System.Collections.Generic;

namespace Develop02
{
    public class Prompts
    {
        public int promptOption;
        public List<string> promptsList = new List<string> {
            "Who was the most interesting person I interacted with today?",
            "What was the best part of my day?",
            "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?",
            "If I had one thing I could do over today, what would it be?",
        };
        public string providePrompt()
        {
            foreach (string prompt in promptsList)
            {
                Console.WriteLine(prompt);
            }
            Console.WriteLine();
            Console.WriteLine("Pcik up one prompt you want by typing its coreponding sequence.");
            promptOption = int.Parse(Console.ReadLine());
            return promptsList[promptOption - 1];
        }
    }
}