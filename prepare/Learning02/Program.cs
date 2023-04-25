using System;
using System.Collections.Generic;

namespace learning02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Learning02 World!");
            List<int> myList = new List<int>();
            myList.Add(121);    //By value
            myList.Add(2021);
            myList.Remove(0);   // By index
            
        }
    }
}