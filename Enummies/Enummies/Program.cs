using System;

namespace Enummies
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter the day of the week. It is Case Sensitive.");
                DaysOfTheWeek day = (DaysOfTheWeek)
                Enum.Parse(typeof(DaysOfTheWeek),
                Console.ReadLine());
                if (day == DaysOfTheWeek.Saturday)
                {
                    Console.WriteLine("You have chosen Saturday");
                }
                if (day == DaysOfTheWeek.Monday)
                {
                    Console.WriteLine("You have chosen Monday");
                }
                if (day == DaysOfTheWeek.Thursday)
                {
                    Console.WriteLine("You have chosen Thursday");
                }
                if (day == DaysOfTheWeek.Tuesday)
                {
                    Console.WriteLine("You have chosen Tuesday");
                }
                if (day == DaysOfTheWeek.Sunday)
                {
                    Console.WriteLine("You have chosen Sunday");
                }
                if (day == DaysOfTheWeek.Wednesday)
                {
                    Console.WriteLine("You have chosen Wednesday");
                }
                if (day == DaysOfTheWeek.Friday)
                {
                    Console.WriteLine("You have chosen Friday");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
            finally
            {
            
                Console.ReadLine();
            }









        }
            public enum DaysOfTheWeek
        {   Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday

        }
        }
    }

