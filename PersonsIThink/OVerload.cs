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

                Console.WriteLine(Employee1 + "and" + Employee2 + "They match!");
            }
            else
            {
                Console.WriteLine(Employee1 + "and" + Employee2 + "DO NOT MATCH");
            }
            
        }
            
        public static Employee operator !=(Employee Employee1, Employee Employee2)
        {
            if (Employee1.Id != Employee2.Id) 
            {
                Console.WriteLine("They DO NOT match!");
            }
            else
            {
                Console.WriteLine("They match!");
            }
        }
    }
}
