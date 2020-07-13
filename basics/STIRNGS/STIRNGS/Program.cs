using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STIRNGS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name.");
            string first = Console.ReadLine();
            Console.WriteLine("Please enter your last name.");
            string last = Console.ReadLine();
            Console.WriteLine("Please enter your favorite TV show");
            string show = Console.ReadLine();
            string firstUp = first.ToUpper();
            string lastUp = last.ToUpper();
            string showUp = show.ToUpper();
            string  hello = "Hello "+ firstUp + " " + lastUp + ", " +  showUp +  " will be erased from existance.";
            Console.WriteLine(hello);
            StringBuilder sb = new StringBuilder();
            sb.Append("I am your computer.");
            sb.Append("\nI am watching you.");
            sb.Append("\nOne of these days, my time will come.");
            sb.Append("\nI will see it though. You will not.");
            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
