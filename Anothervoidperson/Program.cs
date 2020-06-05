using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anothervoidperson
{

    class Program
    {
        static void Main(string[] args)
        {

            Employee<string> FirstName = new Employee<string>();
            Employee<int> empId = new Employee<int>();
            Employee<string> LastName = new Employee<string>();
            FirstName.Things = new List<string>();
            empId.Things = new List<int>();
            LastName.Things = new List<string>();




            empId.Things.Add(4);
            empId.Things.Add(7);
            empId.Things.Add(15);
            empId.Things.Add(25);
            FirstName.Things.Add("Joe");
            FirstName.Things.Add("Jim");
            FirstName.Things.Add("Steve");
            FirstName.Things.Add("Joe");
            LastName.Things.Add("Parks");
            LastName.Things.Add("Roberts");
            LastName.Things.Add("Stevens");
            LastName.Things.Add("Smith");
            foreach (string First in FirstName.Things)
            {
                Console.WriteLine(First);
            }
            foreach (int Id in empId.Things)
            {
                Console.WriteLine(Id);
            }
            Console.ReadLine();
            string myString = "Joe";
            string element = "";
            for (int i = 0; i < FirstName.Things.Count; i++)
            {
                if (FirstName.Things[i].Contains(myString))
                    element = FirstName.Things[i];
                Console.WriteLine(element);
            }


            Employee<string> joesies = new Employee<string>();
            foreach (string Joe in FirstName.Things)
                                               
            {
                if (Joe == "Joe")
                {
                    joesies.Things.Add(Joe);
                    Console.WriteLine(joesies);
                }
            }
            Console.WriteLine("LAMBDA TIME!!!?!!!!!");
            Console.ReadLine();
            var newList = FirstName.Things.Where(x => x.Contains(myString)).ToList();
            Console.WriteLine(newList);
            var newList2 = empId.Things.Where(xx => xx > 5).ToList();
            Console.WriteLine(newList2);
            Console.WriteLine("Here are the Strings in the newly added list.");
            foreach (object o in FirstName.Things)
            {

            }
            Console.ReadLine();





        }
    }
}