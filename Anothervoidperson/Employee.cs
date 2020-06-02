using System;
using System.Collections.Generic;
using System.Text;

namespace Anothervoidperson
{
    public class Employee<T> : Person, IQuittable
    {
        int Id = 44578;
        public List<T> Things { get; set; } = new List<T>();
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