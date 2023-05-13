using System;
using System.Collections.Generic;
using System.IO;

namespace Develop02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            List<Entry> temporalSavedEntries = new List<Entry>();

            int userChoice;
            string fileName = "defaultFileName.txt";
            string loopIndicator = "loop";

            while (loopIndicator != "stop")
            {
                Console.WriteLine("\nPleace select one of the following choice. (number)");
                Console.Write("\n 1. Write\n 2. Display\n 3. Load\n 4. Save\n 5. Quit\n");
                userChoice = int.Parse(Console.ReadLine());

                if (userChoice == 1)
                {
                    Entry myEntry = new Entry();
                    Prompts myPrompts = new Prompts();
                    Journal journal = new Journal();
                    Console.WriteLine(myEntry.prompt = myPrompts.providePrompt());
                    myEntry.response = Console.ReadLine();
                    myEntry.date = "13 May, 2023";
                    myEntry.Store(myEntry.prompt, myEntry.response, myEntry.date);

                    journal.StoreEntry(myEntry);

                    journal.GetAllEntries();

                    foreach (Entry entry in journal.entries) {
                        temporalSavedEntries.Add(entry);
                    }
                    foreach (Entry entry in journal.GetAllEntries())
                    {
                        string message = entry.GetAsString();
                        Console.WriteLine(message);
                    }
                    loopIndicator = "loop";
                }
                else if (userChoice == 2)
                {
                    foreach (Entry entry in temporalSavedEntries)
                    {
                        Console.Write($"{entry.date}\n{entry.prompt}\n{entry.response}\n");
                    }
                    loopIndicator = "loop";
                }
                else if (userChoice == 3)
                {
                    Console.WriteLine("The file name you want to view: (fileName.txt)");
                    fileName = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(fileName);
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                    loopIndicator = "loop";

                }
                else if (userChoice == 4)
                {
                    Console.WriteLine("Type in the file name to which the journal will be saved. (fileName.txt)");
                    fileName = Console.ReadLine();
                    using (StreamWriter outputJournal = new StreamWriter(fileName))
                    {
                        foreach (Entry entry in temporalSavedEntries)
                        {
                            outputJournal.Write($"{entry.date}\n{entry.prompt}\n{entry.response}");
                        }
                        outputJournal.Close();
                    }
                    loopIndicator = "loop";
                }
                else if (userChoice == 5)
                {
                    Console.Write("Goodbye");
                    userChoice = 0;
                    loopIndicator = "stop";
                }
                else if (userChoice == 0)
                {
                    loopIndicator = "loop";
                }
                else
                {
                    Console.WriteLine("Option is not found. Please select your option from 1 to 5.");
                    loopIndicator = "loop";
                }
            }
        }
    }
}