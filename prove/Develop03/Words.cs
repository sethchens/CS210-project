using System;

namespace Develop03 {
    public class Words {
        private static string _words;
        public static string _tempWords;

        public Words(string words) {
            _words += $"{words}\n";
        }

        public static string ReturnWords() {
            return _words;
        }

        public static string ReturnTempWords() {
            return _tempWords;
        }
    };
}