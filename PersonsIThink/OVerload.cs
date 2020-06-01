using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsIThink
{
    class OVerload
    {
        public static Employee operator ==(Employee Employee1, Employee Employee2)
        {
            if (Employee1.Id == Employee2.Id)
            {
                Console.WriteLine("They match!");
            }
        }
        public static Employee operator !=(Employee Employee1, Employee Employee2)
        {
            if (Employee1.Id != Employee2.Id) 
            {
                Console.WriteLine("They DO NOT match!");
            }
        }
    }
}
