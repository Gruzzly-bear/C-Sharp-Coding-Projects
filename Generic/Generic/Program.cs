using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
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






        }
    }
}