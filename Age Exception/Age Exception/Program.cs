using System;

namespace Age_Exception
{
    class Program
    {

    public class AgeException : Exception 
        {                                     
            public AgeException()
                : base() { }
            public AgeException(string message)
            : base(message) { }
        }
        static void Main()
        {
            int inputAge;
            try
            {
                Console.WriteLine("How old are you?");
                inputAge = int.Parse(Console.ReadLine());
                if (inputAge <= 0)
                {
                    throw new AgeException();
                }
                var presentYear = DateTime.Now;
                var ageYear = presentYear.Year - inputAge;
                Console.WriteLine("You are " + inputAge + " and you were born in " + ageYear + "!");
            }
            catch (FormatException)
            {
                Console.WriteLine("Please input numbers only.");
            }
            catch (AgeException)
            {
                Console.WriteLine("Enter a number greater than 0!");
            }
            catch (Exception) 
            {
                Console.WriteLine("An Error occured. Please contact your System Admin.");
                Console.ReadLine();
                return;
            }
            Console.ReadLine();
        }
    }
}
