using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROJECTMATH
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Please input a number.");
            double input1 = Convert.ToDouble(Console.ReadLine());
           
            Console.WriteLine("You have entered " + input1);
            
            Console.WriteLine("We will now multiply that by fifty");
            
            double input2 = input1 * 50;
            Console.WriteLine(input2);
            Console.WriteLine("Please Enter Another number");
            double input3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("We will now add 25 to that number");
            Console.WriteLine(input3 + 25);
            Console.WriteLine("Please Enter Another number");
            double input4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now, we will divide it by 12.5");
            Console.WriteLine(input4 / 12.5);
            Console.WriteLine("Please Enter Another number");
            double input5 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Is it greater than Fifty?");
            Console.WriteLine(input5 > 50);
            Console.WriteLine("Please Enter Another number");
            double input6 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("We will divide it by 7 and print the remainder.");
            Console.WriteLine(input6 % 7);
            Console.ReadLine();
        }
    }
}
