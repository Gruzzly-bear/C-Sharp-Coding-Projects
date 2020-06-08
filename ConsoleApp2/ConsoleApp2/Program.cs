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
            var name1 = Console.ReadLine();
            Fname fname1 = new Fname(name1);
            Console.WriteLine("Your name is " + fname1.inputName1 + " and your starting health is " + fname1.inputHealth1  );
            Console.ReadLine();





        }
        }
    }