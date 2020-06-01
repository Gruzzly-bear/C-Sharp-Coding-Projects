using System;
using System.Collections.Generic;

using System.Runtime.InteropServices.ComTypes;

namespace Anothervoidperson
{

    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> strang = new Employee<string>();
            Employee<int> ant = new Employee<int>();
            ant.ADD(4);
            strang.Add("Dog");
            
            
            
            
            Console.ReadLine();
           
            // IQuittable quits = new Employee();
            // quits.Quit();

            //placeHolder.firstName = "Sample";
           //placeHolder.lastName = "Student";
            //placeHolder.SayName();
        

        }
    }
}