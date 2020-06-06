using System;
using System.IO;

namespace IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hey there! Please enter a number!");
            int inputOne = Convert.ToInt32(Console.ReadLine());
            using (StreamWriter file = new StreamWriter(@"C:\The-Tech-Academy-C-Sharp-Coding-Projects\IO\input.txt"))
            {
                file.WriteLine(inputOne);
                string text = File.ReadAllText(@"C:\The-Tech-Academy-C-Sharp-Coding-Projects\IO\input.txt");
                Console.WriteLine("You have entered " + text);
            }
        }
    }
}
