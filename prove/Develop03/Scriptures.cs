using System;
using System.Collections.Generic;

namespace Develop03 {
    public class Scriptures {
        private static Dictionary<string, string> _scriptures;
        private static Dictionary<string, string> _modifiedScriptures;
        private static int _hideWordIndex;
        private static string[] _tempArray;
        static Random random = new Random();
        public void GetScriptures() {
            _scriptures.Add(Reference.ReturnReference(), Words.ReturnWords());
        }
        public static Dictionary<string, string> ReturnScriptures() {
            return _scriptures;
        }

        public static void HideWord(Dictionary<string, string> _scriptures) {
            _tempArray = Words.ReturnWords().Split(" ");
            _hideWordIndex = random.Next(1, _tempArray.Length - 1);

            foreach (string word in _tempArray) {
                if (_tempArray[_hideWordIndex] != word) {
                    Words._tempWords  += word;
                }
            }
            _modifiedScriptures.Add(Reference.ReturnReference(), Words.ReturnTempWords());
        }

        public Dictionary<string, string> ReturnModifiedScriptures() {
            return _modifiedScriptures;
        }
    }
}