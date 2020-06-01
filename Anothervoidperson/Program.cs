using System;

namespace Anothervoidperson
{

    class Program
    {
        static void Main(string[] args)
        {
            Employee placeHolder = new Employee();
            IQuittable quits = new Employee();
            quits.Quit();

            placeHolder.firstName = "Sample";
            placeHolder.lastName = "Student";
            placeHolder.SayName();
        

        }
    }
}