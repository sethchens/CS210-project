using System;

namespace Develop03{
    class Program
    {
        static void Main(string[] args)
        {
            Scriptures scriptures = new Scriptures();
            Prompt prompt = new Prompt();
            Console.WriteLine("Enter the reference of the scriptures:");
            string theReference = Console.ReadLine();
            1
            int verseNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the corresponding scriptures:");
            string theWords = Console.ReadLine();

            Reference reference = new Reference(theReference);
            Reference reference2 = new Reference(theReference, verseNumber);
            Words words = new Words(theWords);

            scriptures.GetScriptures();
            Console.Clear();
            scriptures.ReturnModifiedScriptures();

            do {
                Console.WriteLine("Press enter key to hide one word in the" + 
                                  "scripture, or type 'quit' to quit the program:");
                prompt._prompt = Console.ReadLine();
                prompt.hideOrQuit();
            } while (prompt._prompt != "quit");
        }
    }
};