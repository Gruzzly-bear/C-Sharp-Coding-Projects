using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMPARE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1");
            Console.WriteLine("Hourly Rate?");
            int p1hourly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours Worked per week?");
            int p1hoursworked = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("Hourly Rate?");
            int p2hourly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours Worked per week?");
            int p2hoursworked = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Annual salary of Person 1");
            int p1pt1 = p1hourly * 2080;
            Console.WriteLine(p1pt1);
            Console.WriteLine("Annual salary of Person 2");
            int p2pt1 = p2hourly * 2080;
            Console.WriteLine(p2pt1);
            Console.WriteLine("Does Person 1 make more money that Person 2?");
            Console.WriteLine(p1pt1 > p2pt1);
            Console.ReadLine();







        }
    }
}
