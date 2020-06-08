using Constructors;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
    {
        class Program
        {
            static void Main(string[] args)
            {
            Fname fname = new Fname();
            Fname newFname = new Fname("World Boss");
            Console.WriteLine("Please enter your name!");
            var firstName = Console.ReadLine();
            Console.WriteLine("Please enter your starting health!");
            var inputHealth = Convert.ToInt32(Console.ReadLine());
            fname.inputHealth = inputHealth;
            Console.WriteLine("Your name is " + firstName + " and your starting health is " + fname.inputHealth );
            Console.ReadLine();
            Console.WriteLine(" You will battle " + newFname.inputName + " whose health is at " + newFname.inputHealth);




        }
        }
    }