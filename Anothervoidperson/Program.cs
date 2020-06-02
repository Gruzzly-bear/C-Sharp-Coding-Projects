using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace Anothervoidperson
{

    class Program
    {
        static void Main(string[] args)
        {
            
            Employee<string> Fname = new Employee<string>();
            Employee<int> Id = new Employee<int>();
            Employee<string> Lname = new Employee<string>();


            Id.Id.Add(4);
            Id.Id.Add(7);
            Id.Id.Add(15);
            Id.Id.Add(25);
            Fname.Fname.Add("Joe");
            Fname.Fname.Add("Jim");
            Fname.Fname.Add("Steve");
            Fname.Fname.Add("Joe");
            Lname.Lname.Add("Parks");
            Lname.Lname.Add("Roberts");
            Lname.Lname.Add("Stevens");
            Lname.Lname.Add("Smith");
          //  Console.WriteLine("Here are the Ints in the newly added list.");
            string myString = "Joe";
            string element = "";
            for (int i = 0; i < Fname.Fname.Count; i++)
            {
                if (Fname.Fname[i].Contains(myString))
                    element = Fname.Fname[i];
                Console.WriteLine(element);
            }
            Console.WriteLine("LAMBDA TIME!!!?!!!!!");
            Console.ReadLine();
            var newList = Fname.Fname.Where(x => x.Contains(myString)).ToList();
            Console.WriteLine(newList);
            var newList2 = Id.Id.Where(xx => xx > 5).ToList();
            Console.WriteLine(newList2);
            //  Console.WriteLine("Here are the Strings in the newly added list.");
            //  foreach (object o in Fname.Things)
            //  {

            //  }
            // Console.ReadLine();

            // IQuittable quits = new Employee();
            // quits.Quit();

            //placeHolder.firstName = "Sample";
            //placeHolder.lastName = "Student";
            //placeHolder.SayName();


        }
    }
}