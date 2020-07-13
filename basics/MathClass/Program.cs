using System;
using System.Collections.Generic;
using System.Text;

namespace MathClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, please input a number.");
            int numBer = Convert.ToInt32(Console.ReadLine());
          
            var operatorObject = new MathStuff();
            int addIt = operatorObject.Addtheinput(numBer, 5);
            int minusIt = operatorObject.Minustheinput(numBer, 5);
            int multiplyIt = operatorObject.Multiplytheinput(numBer, 5);
            Console.WriteLine("We will add the number to Five.");
            Console.ReadLine();
            Console.WriteLine(addIt);
            Console.WriteLine("We will minus Five from the number.");
            Console.ReadLine();
            Console.WriteLine(minusIt);
            Console.WriteLine("We will multiple the number by Five.");
            Console.ReadLine();
            Console.WriteLine(multiplyIt);
            Console.ReadLine();
        }
    }
}
