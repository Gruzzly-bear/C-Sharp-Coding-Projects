using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please input a number");
            double inputNum = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine(" We will now Multiply that number by 50");
            double inputNumfifty = inputNum * 50;
            Console.WriteLine(" Your number - " ,inputNum ,"Times 50 is" ,inputNumfifty);
            

        }
    }
}
