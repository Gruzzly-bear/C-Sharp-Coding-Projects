using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NewListEmp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<EmployeeList> Employee = new List<EmployeeList>()
            {
            new EmployeeList() { FName = "Robert", LName = "Robertson", Id = 1 },
            new EmployeeList() { FName = "Joe", LName = "TigerMan", Id = 10 },
            new EmployeeList() { FName = "Steve", LName = "Stevens", Id = 2 },
            new EmployeeList() { FName = "Mark", LName = "Marks", Id = 2 },
            new EmployeeList() { FName = "Garrosh", LName = "Hellscream", Id = 20 },
            new EmployeeList() { FName = "Deckard", LName = "Cain", Id = 30 },
            new EmployeeList() { FName = "Robert", LName = "Bobsin", Id = 4 },
            new EmployeeList() { FName = "Brandon", LName = "Flowers", Id = 50 },
            new EmployeeList() { FName = "Jim", LName = "Jimmers", Id = 4 },
            new EmployeeList() { FName = "Joe", LName = "isangry", Id = 3 }
            };
            Console.ReadLine();
            List<EmployeeList> Joesies = new List<EmployeeList>();
            Console.WriteLine("This is not a Lambda.");
            foreach (EmployeeList name in Employee)
            {
                if (name.FName == "Joe")
                {
                    Joesies.Add(name);
                    Console.WriteLine(name.FName);

                }
            }
            Console.ReadLine();
            List<EmployeeList> moreJoes = new List<EmployeeList>();
            moreJoes = Employee.Where(x => x.FName == "Joe").ToList();
            Console.WriteLine("This was made using a Lambda");
            foreach (EmployeeList joesie in moreJoes)
            {
                Console.WriteLine(joesie.FName);
            }
            Console.ReadLine();
            List<EmployeeList> idList = new List<EmployeeList>();
            Console.WriteLine("This is a list of Employees with an Id greater than 5. Aren't they awesome!");
            idList = Employee.Where(x => (x.Id > 5)).ToList();
            foreach (EmployeeList employeeId in idList)
            {
                Console.WriteLine(employeeId.FName + " " + employeeId.LName + " Whose Id is " + employeeId.Id);
            }
            Console.ReadLine();
        }
    }
}
