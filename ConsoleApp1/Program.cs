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
            Console.WriteLine("Enter a decimel!");
            double intOne = Convert.ToDouble(Console.ReadLine());
            blip.Boop((int)intOne);
            Console.ReadLine();
        }

    }
}
