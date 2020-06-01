using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Channels;

namespace PersonsIThink
{
    class OVerload
    {
        public static bool operator ==(Employee Employee1, Employee Employee2)
        {
            var wat = Employee1.Id == Employee2.Id;
            var boop = Employee1.Id != Employee2.Id;
            if (wat == true)
            {

                return wat;
            }
            else
            {
                return boop;
            }
            
        }
            
        public static bool operator !=(Employee Employee1, Employee Employee2)
        {
            var wat = Employee1.Id == Employee2.Id;
            var boop = Employee1.Id != Employee2.Id;
            if (wat == false) 
            {
                return boop;
            }
            else
            {
                return wat;
            }
        }
    }
}
