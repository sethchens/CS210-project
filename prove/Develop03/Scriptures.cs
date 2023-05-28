using System;
using System.Collections.Generic;

namespace Develop03
{
    public class Scriptures
    {
        private static Dictionary<string, string> _scriptures;
        private static Dictionary<string, string> _modifiedScriptures;
        private static int _hideWordIndex;
        private static string[] _tempArray;
        static Random random = new Random();
        public void GetScriptures()
        {
            _scriptures.Add(Reference.ReturnReference(), Words.ReturnWords());
        }
        public Dictionary<string, string> ReturnScriptures()
        {
            return _scriptures;
        }

        static Scriptures()
        {
            _scriptures = new Dictionary<string, string>();
            _modifiedScriptures = new Dictionary<string, string>();
        }

        public static void HideWord(Dictionary<string, string> _scriptures)
        {
            _tempArray = Words.ReturnWords().Split(" ");
            _hideWordIndex = random.Next(0, _tempArray.Length - 1);

            // Reset _tempWords so when iterate it won't have
            // the value from the previous loop.
            Words._tempWords = "";

            foreach (string word in _tempArray)
            {
                if (word != _tempArray[_hideWordIndex])
                {
                    Words._tempWords += $"{word} ";
                }
                else if (_tempArray[_hideWordIndex] == word)
                {
                    Words._tempWords += "_ ";
                }
            }
            _modifiedScriptures.Clear();
            _modifiedScriptures.Add(Reference.ReturnReference(), Words.ReturnTempWords());
            foreach (KeyValuePair<string, string> pair in _modifiedScriptures)
            {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }
        }

        public Dictionary<string, string> ReturnModifiedScriptures()
        {
            return _modifiedScriptures;
        }
    }
}