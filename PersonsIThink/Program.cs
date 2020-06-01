using System;

namespace PersonsIThink
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee placeHolder = new Employee();
            Employee1 bip = new Employee1();
            Employee2 bop = new Employee2();
            
            bip.FirstName = "bob";
            bip.LastName = "Roberts";
            bip.Id = 4456;
            bop.FirstName = "Jim";
            bop.LastName = "Jimmers";
            bop.Id = 4455;
            
            placeHolder.FirstName = "Sample";
            placeHolder.LastName = "Student";
            placeHolder.SayName();
        }
    }
}
