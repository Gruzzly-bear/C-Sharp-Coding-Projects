using Fav_super.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Fav_super.DAL
{
    public class PageContext : DbContext
    {

        public PageContext() : base("PageContext")
        {
        }

        public DbSet<Person> People { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}