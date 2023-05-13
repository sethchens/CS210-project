using System;
using System.Collections.Generic;

namespace Develop02{
    ///<sumary>
    ///The responsity od the Entry is to store entry.
    public class Journal
    {
        public List<Entry> entries = new List<Entry>();
        public List<Entry> GetAllEntries()
        {
            return entries;
        }

        public void StoreEntry(Entry entry)
        {
            if (!entries.Contains(entry))
            {
                entries.Add(entry);
            }
        }
    }
}