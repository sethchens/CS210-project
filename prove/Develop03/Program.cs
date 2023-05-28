using System;

namespace Develop03
{
    class Program
    {
        static void Main(string[] args)
        {
            Prompt prompt = new Prompt();
            Console.WriteLine("Enter the reference of the scriptures:");
            string theReference = Console.ReadLine();
            Console.WriteLine("Enter the number of verses of your reference:");
            int verseNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the corresponding scriptures:");
            string theWords = Console.ReadLine();

            Scriptures scriptures = new Scriptures();
            Reference reference = new Reference(theReference);
            Reference reference2 = new Reference(theReference, verseNumber);
            Words words = new Words(theWords);

            scriptures.GetScriptures();
            Console.Clear();
            Dictionary<string, string> scriptureToPrint = new Dictionary<string, string>();
            scriptureToPrint = scriptures.ReturnScriptures();
            foreach (KeyValuePair<string, string> pair in scriptureToPrint) {
                Console.WriteLine(pair.Key + ": " + pair.Value);
            }

            Console.WriteLine("Press enter key to hide one word in the" +
                              "scripture, or type 'quit' to quit the program:");
            prompt._prompt = Console.ReadLine();
            Console.Clear();

            while (prompt._prompt != "quit" && prompt._prompt == "") {
                Console.Clear();
                prompt.hideOrQuit();
                Console.WriteLine("Press enter key to hide one word in the" +
                                  "scripture, or type 'quit' to quit the program:");
                prompt._prompt = Console.ReadLine();
            }
        }
    }
}