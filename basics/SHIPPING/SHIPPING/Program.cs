using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHIPPING
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please Follow the instructions below.");
            Console.WriteLine("Please enter the package Weight?");
            int weight = Convert.ToInt32(Console.ReadLine());
            if (weight > 50)
            {
                Console.WriteLine("Package is too heavy to be shipped via Package Express!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("Please enter the package Width.");
            int width = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the package Height.");
            int height = Convert.ToInt32(Console.ReadLine());
            if (width + height > 50)
            {
                Console.WriteLine("Package is too big to be shipped via Package Express!");
                Console.ReadLine();
                Environment.Exit(0);
            }
            int quote = weight * width * height / 100;
            Console.WriteLine("Your estimated total for shipping this package is: $" + quote);
            Console.ReadLine();
        }

    }
}
