using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace Fav_super.Models
{
    public class Movie
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MovieID { get; set; }
        public string Title { get; set; }
        public int Tomatoes { get; set; }

        public virtual ICollection<Rating> Ratings { get; set; }
    }
}