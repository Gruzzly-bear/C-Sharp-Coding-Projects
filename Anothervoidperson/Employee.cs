using System;
using System.Collections.Generic;
using System.Text;

namespace Anothervoidperson
{
    public class Employee<T> : Person, IQuittable
    {
        //int Id = 44578;
        public List<T> Fname { get; set; } = new List<T>();
        public List<T> Lname { get; set; } = new List<T>();
        public List<T> Id { get; set; } = new List<T>();
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