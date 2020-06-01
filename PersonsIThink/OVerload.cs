using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsIThink
{
    class OVerload
    {
        public static Employee operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
            {
                Console.WriteLine("They match!");
            }
        }
        public static Employee operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.Id != employee2.Id) 
            {
                Console.WriteLine("They DO NOT match!");
            }
        }
    }
}
