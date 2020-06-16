using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace FavoriteSuper.Models
{
    public class PersonContext : DbContext
    {
        public DbSet<People> Peoples { get; set; }
    }
}