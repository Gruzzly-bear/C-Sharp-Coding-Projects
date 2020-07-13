using System;
using System.Collections.Generic;
using System.Text;

namespace displaysecond
{
    public class Program
    {
        public static void Main()
        {
            IdkMaybe beep = new IdkMaybe();
            Console.WriteLine("Please enter a number.");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number.");
            int inputTwo = Convert.ToInt32(Console.ReadLine());
            beep.Surething(inputOne, inputTwo);


            Console.ReadLine();
        }
    }
}
