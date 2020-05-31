using System;

namespace PersonsIThink
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee placeHolder = new Employee();

           

            placeHolder.FirstName = "Sample";
            placeHolder.LastName = "Student";
            placeHolder.SayName();
        }
    }
}
