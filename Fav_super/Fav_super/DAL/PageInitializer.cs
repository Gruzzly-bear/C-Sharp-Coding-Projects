using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Fav_super.Models;

namespace Fav_super.DAL
{
    public class PageInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<PageContext>
    {
        protected override void Seed(PageContext context)
        {
            var people = new List<Person>
            {
            new Person{FirstName="Robert",LastName="Downsy",RatingDate=DateTime.Parse("2015-04-25")},
            new Person{FirstName="Peter",LastName="Parker",RatingDate=DateTime.Parse("2019-03-16")},
            new Person{FirstName="Bruce",LastName="Gotham",RatingDate=DateTime.Parse("1995-01-02")},
            new Person{FirstName="Ginger",LastName="Fightus",RatingDate=DateTime.Parse("2008-11-07")},
            new Person{FirstName="Mista",LastName="Jay",RatingDate=DateTime.Parse("2099-10-01")},
            new Person{FirstName="Logan",LastName="Luther",RatingDate=DateTime.Parse("2016-04-08")},
            new Person{FirstName="Park",LastName="Peters",RatingDate=DateTime.Parse("2003-02-01")},
            new Person{FirstName="Miles",LastName="Moremiles",RatingDate=DateTime.Parse("2005-12-25")}
            };

            people.ForEach(s => context.People.Add(s));
            context.SaveChanges();
            var movies = new List<Movie>
            {
            new Movie{MovieID=1,Title="Spiderman",Tomatoes=3,},
            new Movie{MovieID=2,Title="Batman",Tomatoes=3,},
            new Movie{MovieID=3,Title="Fatman and Blarth",Tomatoes=9,},
            new Movie{MovieID=4,Title="Real Life",Tomatoes=4,},
            new Movie{MovieID=5,Title="Don't eat that. Ew",Tomatoes=4,},
            new Movie{MovieID=6,Title="Who are me",Tomatoes=3,},
            new Movie{MovieID=7,Title="Turtleman",Tomatoes=4,}
            };
            movies.ForEach(s => context.Movies.Add(s));
            context.SaveChanges();
            var ratings = new List<Rating>
            {
            new Rating{PersonID=1,MovieID=1,Score=Score.A},
            new Rating{PersonID=1,MovieID=7,Score=Score.C},
            new Rating{PersonID=1,MovieID=5,Score=Score.B},
            new Rating{PersonID=2,MovieID=6,Score=Score.B},
            new Rating{PersonID=2,MovieID=2,Score=Score.F},
            new Rating{PersonID=2,MovieID=1,Score=Score.F},
            new Rating{PersonID=3,MovieID=4},
            new Rating{PersonID=4,MovieID=4,},
            new Rating{PersonID=4,MovieID=3,Score=Score.F},
            new Rating{PersonID=5,MovieID=5,Score=Score.C},
            new Rating{PersonID=6,MovieID=2},
            new Rating{PersonID=7,MovieID=3,Score=Score.A},
            };
            ratings.ForEach(s => context.Ratings.Add(s));
            context.SaveChanges();
        }
    }
}