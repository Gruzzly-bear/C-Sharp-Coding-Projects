using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please input a number to divide our numbers by."); // Adding array items to the input string
            


            int[] int1 = { 10, 20, 30, 45, 65, 78, 80, 1255 };
            try
            {
                var inputNum = Convert.ToInt32(Console.ReadLine());
                for (int i = int1.Length - 1; i >= 0; i--)
                {
                    int k = int1[i] / inputNum;
                    Console.WriteLine(k);
                }
                Console.ReadLine();


            }
            catch (DivideByZeroException ex)
            {

                Console.WriteLine("You cannot divide by Zero! Only Chuck can!", ex);
                

            }
            catch (FormatException ex)
            {

                Console.WriteLine("That is not a number!", ex);
                
            }
            finally
            {
                Console.WriteLine("Thank you for running the program!");
            }
        }
    }
}
