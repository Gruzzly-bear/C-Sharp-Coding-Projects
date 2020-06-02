using System;
using System.Collections.Generic;

using System.Runtime.InteropServices.ComTypes;

namespace Anothervoidperson
{

    class Program
    {
        static void Main(string[] args)
        {
            
            Employee<string> strang = new Employee<string>();
            Employee<int> ant = new Employee<int>();
            

            ant.Things.Add(4);
            ant.Things.Add(7);
            ant.Things.Add(15);
            ant.Things.Add(25);
            strang.Things.Add("Bob");
            strang.Things.Add("Jim");
            strang.Things.Add("Steve");
            strang.Things.Add("Phil");
            Console.WriteLine("Here are the Ints in the newly added list.");
            foreach (object o in ant.Things)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("Here are the Strings in the newly added list.");
            foreach (object o in strang.Things)
            {
                Console.WriteLine(o);
            }
            Console.ReadLine();
           
            // IQuittable quits = new Employee();
            // quits.Quit();

            //placeHolder.firstName = "Sample";
           //placeHolder.lastName = "Student";
            //placeHolder.SayName();
        

        }
    }
}