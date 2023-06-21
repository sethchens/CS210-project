using System;
using System.Diagnostics;

namespace Develop04 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in the corespoding numebr to begin the activity");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            int number = int.Parse(Console.ReadLine());
            switch (number) {
                case 1:
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.StartMessage();
                    Console.Write("Type in and set the duration you want:");
                    int duration1 = int.Parse(Console.ReadLine());
                     breathingActivity.GetDuration(duration1);
                     DateTime startTime1 = DateTime.Now;
                     DateTime futureTime1 = startTime1.AddSeconds(duration1);

                     while (startTime1 < futureTime1) {
                         breathingActivity.BreathPrompt();
                         startTime1 = DateTime.Now;
                     }

                    breathingActivity.EndMessage();
                    break;
                case 2:
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.StartMessage();
                    Console.Write("Type in and set the duration you want:");
                    int duration2 = int.Parse(Console.ReadLine());
                    reflectionActivity.GetDuration(duration2);
                    DateTime startTime2 = DateTime.Now;
                    DateTime futureTime2 = startTime2.AddSeconds(duration2);

                    while (startTime2 < futureTime2) {
                        reflectionActivity.PromptRandomPrompt();
                        reflectionActivity.StoreRandomPromptAnswer(Console.ReadLine());
                        reflectionActivity.PromptReflectOnPrompt();
                        reflectionActivity.StoreReflectOnAnswer(Console.ReadLine());
                        startTime2 = DateTime.Now;
                    }
                    reflectionActivity.EndMessage();
                    break;
                case 3:
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.StartMessage();
                    Console.Write("Type in and set the duration you want:");
                    int duration3 = int.Parse(Console.ReadLine());
                    listingActivity.GetDuration(duration3);
                    DateTime startTime3 = DateTime.Now;
                    DateTime futureTime3 = startTime3.AddSeconds(duration3);
                    
                    while (startTime3 < futureTime3) {
                        listingActivity.PromptThinkingTopic();
                        string answer = Console.ReadLine();
                        listingActivity.StoreUserAnswer(answer);
                        startTime3 = DateTime.Now;
                    }
                    listingActivity.DisplayNumberOfUserAnswer();
                    listingActivity.EndMessage();
                    break;
            }
        }
    }
}