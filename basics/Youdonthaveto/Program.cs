using System;
using System.Collections.Generic;
using System.Text;

namespace Youdonthaveto
{
    class Program
    {
        static void Main(string[] args)
        {
            Ifyouwanna pick = new Ifyouwanna();
            Console.WriteLine("Please pick a number.");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter another number. If you do not, default of Zero will be used.You don't have to pick. No one if forcing you.");
            int final;
            if (int.TryParse(Console.ReadLine(), out int inputTwo)){
                final = pick.Maybe(inputOne, inputTwo);
            }
                
            else
                final = pick.Maybe(inputOne);

            int methodTwo = pick.Maybe(inputOne, inputTwo);


            Console.WriteLine(inputOne + " plus " + inputTwo + " Equals " + methodTwo);
            Console.ReadLine();
        }
    }
}
