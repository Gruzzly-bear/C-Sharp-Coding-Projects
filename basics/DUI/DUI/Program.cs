using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUI
{
    class Program
    {
        static void Main(string[] args)
        {
        Console.WriteLine("How old are you?");
        int age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Have you ever had a DUI? Yes or No.");
        string dui = Console.ReadLine();
        Console.WriteLine("How many speeding tickets do you have?");
        int ticket = Convert.ToInt32(Console.ReadLine());
        if (age > 15 && dui == "No" && ticket <= 3)
        {
            Console.WriteLine("You are Qualified");
        }
        else
        {
            Console.WriteLine("You are not Qualified");
        }
            Console.ReadLine();
        }
    }
}
