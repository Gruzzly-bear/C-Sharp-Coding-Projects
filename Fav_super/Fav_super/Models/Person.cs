using System;
using System.Collections.Generic;

namespace Fav_super.Models
{
    public class Person
    {
        public int ID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime RatingDate { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
    }
}