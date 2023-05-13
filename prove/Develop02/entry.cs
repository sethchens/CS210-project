using System;
using System.Collections.Generic;

namespace Develop02
{
    ///<sumary>
    ///The responsity od the Entry is to record(or sotre) a prompt,
    ///response, and date.
    public class Entry
    {
        public string prompt;
        public string response;
        public string date;
        public string GetAsString()
        {
            return $"\n{date}\n{prompt}\n{response}\n";
        }

        public void Store(string prompt, string response, string date)
        {
            this.prompt = prompt;
            this.response = response;
            this.date = date;
        }
    }
}