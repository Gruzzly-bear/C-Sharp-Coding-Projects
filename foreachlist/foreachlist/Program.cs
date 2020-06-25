using System;
using System.Collections.Generic;
using System.Linq;

namespace foreachlist
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] animalList = { " Dog", " Cat", " Fish", " Rabbit", " Bear" };
            Console.WriteLine("Please enter a color");
            var colorInput = Console.ReadLine();
            foreach (var l in animalList)
            {
                Console.WriteLine(colorInput + l);
            }
            Console.ReadLine();


            Console.WriteLine("Here is our infinite loop");
            int f = 0;
            while (f < 10) // was while (true)
            {
                Console.WriteLine(f);
                f++;
            }
            Console.WriteLine("We fixed it, so we can now continue");
            Console.ReadLine();
            Console.WriteLine("Here is a for loop using <");
            Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Value of o: {0}", i);
            }
            Console.WriteLine("Here is a for loop using <=");
            Console.ReadLine();
            for (int o = 0; o <= 10; o++)
            {
                Console.WriteLine("Value of o: {0}", o);
            }
            string[] shapes = { "Square", "Circle", "Triangle", "Rectangle", "Dog" };
            Console.WriteLine("Please search either : Circle, Square, Triangle, Dog, or Rectangle.");
            var inputOne = Console.ReadLine();
            for (int z = 0; z < 6; z++) 
            { 
                if (shapes.Contains(inputOne))
                {
                    var index = Array.FindIndex(shapes, row => row.Contains(inputOne));
                    Console.WriteLine("The index is " + index);
                    break;
                }
                else
                {
                    Console.WriteLine("Was not on the list!");
                
                }
            }
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
