using System;

namespace Struct
{
    class Program
    {
        static void Main(string[] args)
        {
            Number amount1 = new Number();
            amount1.Amount = 45.7;
            Console.WriteLine(amount1.Amount);
            Console.ReadLine();
        }
    }
}
