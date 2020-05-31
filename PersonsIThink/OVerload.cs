using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsIThink
{
    class Overload
    {
        public static bool operator ==(Employee employee, Person person)
        {
            return true;
        }
        public static bool operator !=(Employee employee, Person person)
        {
            return Employee.Id == person.Id;
        }
    }
}
