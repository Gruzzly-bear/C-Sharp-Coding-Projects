using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOWHILE
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many fingers am I holding up?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool fingers = number == 11;

            do
            {
                switch (number) {
                    case 1:
                        Console.WriteLine("I am not holding just one finger up. Guess again!");
                        Console.WriteLine("How many fingers am I holding up?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 11:
                        Console.WriteLine("I am holding up Eleven fingers! One of them isn't mine though.");
                        fingers = true;
                        break;
                    case 10:
                        Console.WriteLine("I am not holding up both hands. Guess again!");
                        Console.WriteLine("How many fingers am I holding up?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case  9:
                        Console.WriteLine("If I was missing a finger on a hand maybe!");
                        Console.WriteLine("How many fingers am I holding up?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("Sorry, so close! Guess again!");
                        Console.WriteLine("How many fingers am I holding up?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!fingers);

            Console.Read();
        }
    }
}
