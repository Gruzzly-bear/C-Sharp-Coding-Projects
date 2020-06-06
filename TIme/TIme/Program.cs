using System;
using System.Data;

namespace TIme
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("The time and Date is " + currentTime.ToString());
            Console.WriteLine("Please enter a number!");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("It will be " + DateTime.Now.AddHours(inputOne) +", " + inputOne + " hours from now!" );
            Console.ReadLine();
        }

    }
}

