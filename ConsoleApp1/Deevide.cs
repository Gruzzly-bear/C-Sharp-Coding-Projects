using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Deevide
    {
        public void Boop(int inputOne)
        {
            int bop = inputOne / 2;
            Console.WriteLine(bop);


        }
        public bool Boop(int intOne2, int intTwo, out bool done)
        {
            

                if (intOne2 > intTwo)
                {
                done = true;
                return true;
                }

                else
                {
                done = false;
                    return false;
                }

            

        }

    }
}
