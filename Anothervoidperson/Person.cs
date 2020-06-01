using System;
using System.Collections.Generic;
using System.Text;

namespace Anothervoidperson
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public virtual void SayName()
        {
            Console.WriteLine("Name:" + firstName + " " + lastName);
        }


    }
}
