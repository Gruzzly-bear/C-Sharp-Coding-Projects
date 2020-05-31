using System;
using System.Collections.Generic;
using System.Text;

namespace Anothervoidperson
{
    public class Employee : Person
    {
        int Id = 44578;
        public override void SayName()
        {
            Console.WriteLine("Name:" + firstName + " " + lastName);
        }
            
}
}