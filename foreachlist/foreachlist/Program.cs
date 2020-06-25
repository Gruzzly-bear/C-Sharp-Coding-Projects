using System;
using System.Collections.Generic;

namespace foreachlist
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nameList = { "Bob", "Tom", "Ryan", "Phil", "Ryan" };
            var myList = new List<string>();
            var copies = new List<string>();
            foreach (var x in nameList)
            {
                if (!myList.Contains(x))
                    myList.Add(x);
                else
                    copies.Add(x);
            }
            Console.WriteLine("Here is the list of names; ");
            Console.ReadLine();
            foreach (var name in nameList)
            {
                Console.WriteLine(name);
            }
            Console.ReadLine();
            foreach (var copy in copies)
                Console.WriteLine(copy + " is on the list twice.");
                Console.ReadLine();
        }
    }
}
