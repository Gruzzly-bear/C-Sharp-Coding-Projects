﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Deevide blip = new Deevide();
            Console.WriteLine("Enter a number! We will divide it by 2");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            blip.Boop(inputOne);
            Console.ReadLine();
            Console.WriteLine("Enter another number!");
            int intOne2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number! We will see if it is less than the last entered number!");
            int intTwo = Convert.ToInt32(Console.ReadLine());
            bool done = false;
            bool flooop = blip.Boop(intOne2, intTwo, out done);
            
            Console.WriteLine(flooop);
            Console.ReadLine();
        }

    }
}
