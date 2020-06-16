using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fav_super.Models
{
    public enum Score
    {
        A, B, C, D, F
    }

    public class Rating
    {
        public int RatingID { get; set; }
        public int MovieID { get; set; }
        public int PersonID { get; set; }
        public Score? Score { get; set; }

        public virtual Movie Movie { get; set; }
        public virtual Person Person { get; set; }
    }
}
