using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsIThink
{
    class OVerload
    {
        public static bool operator ==(Employee Employee1, Employee Employee2)
        {
            
            if (Employee1.Id == Employee2.Id)
            {

                return true;
            }
            else
            {
                return false;
            }
            
        }
            
        public static bool operator !=(Employee Employee1, Employee Employee2)
        {
            if (Employee1.Id != Employee2.Id) 
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
