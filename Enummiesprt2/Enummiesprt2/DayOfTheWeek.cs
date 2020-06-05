using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enummiesprt2
{
    public class DaysOfTheWeek
    {
        public Day DayOfTheWeek { get; set; } 
    }
    public enum Day
    {
        monday,
        tuesday,
        wednesday,
        thursday,
        friday,
        saturday,
        sunday
    }
}
