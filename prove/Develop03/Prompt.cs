using System;

namespace Develop03 {
    public class Prompt {
        public string _prompt;
        public ConsoleKey enterKey = ConsoleKey.Enter;

        public void hideOrQuit() {
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (_prompt == "quit") {
                Environment.Exit(0);
            }
            else if (_prompt == ""){
                Scriptures.HideWord(Scriptures.ReturnScriptures());
            }
            else {
                Console.WriteLine("Please type either 'quit' oe press Enter.");
            }
        }
    }
}