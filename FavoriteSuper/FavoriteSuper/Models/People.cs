using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FavoriteSuper.Models
{
    public class People
    {
        [Key]
        public int PersonID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Hero { get; set; }

    }
}