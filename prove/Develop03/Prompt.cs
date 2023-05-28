using System;

namespace Develop03 {
    public class Prompt {
        public string _prompt;
        public ConsoleKey enterKey = ConsoleKey.Enter;
        Scriptures scriptures = new Scriptures();

        public void hideOrQuit() {
            if (_prompt == "quit") {
                return;
            }
            else if (_prompt == ""){
                Scriptures.HideWord(scriptures.ReturnModifiedScriptures());
            }
            else {
                Console.WriteLine("Please type either 'quit' or press Enter.");
            }
        }
    }
}