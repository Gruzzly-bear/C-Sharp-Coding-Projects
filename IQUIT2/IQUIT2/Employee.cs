using System;
using System.Collections.Generic;
using System.Text;

namespace IQUIT2
{

    public class Employee : Person, IQuittable
    {

        public void Quit()
        {
            throw new NotImplementedException();
        }

        public override void SayName()
        {
            Console.WriteLine("Name:" + firstName + " " + lastName);
        }

    }
}
