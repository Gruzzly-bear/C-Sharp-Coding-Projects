using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsIThink
{
    class OVerload
    {
        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (employee1.Id == employee2.Id)
            {
                return true;
            }
        }
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            if (employee1.Id != employee2.id);
            {
                return false;
            }
        }
    }
}
