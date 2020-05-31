using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Deevide blip = new Deevide();
            Console.WriteLine("Enter a number!");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            blip.Boop(inputOne);
            Console.ReadLine();
            Console.WriteLine("Enter another number!");
            int intOne2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number! if it is less than the last entered number!");
            int intTwo = Convert.ToInt32(Console.ReadLine());
            bool flooop = blip.Boop(intOne2, intTwo);
            Console.WriteLine(flooop);
            Console.ReadLine();
        }

    }
}
