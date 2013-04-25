namespace AtaUte.Migrations
{
    using AtaUte.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<AtaUte.Models.AtaUteDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(AtaUte.Models.AtaUteDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            context.Restaurants.AddOrUpdate(r => r.Name,
                new Restaurant { Name = "Smaka", City = "Göteborg", Country = "Sverige" },
                new Restaurant { Name = "Pasta+", City = "Göteborg", Country = "Sverige" },
                new Restaurant { Name = "Orient", City = "Stockholm", Country = "Sverige" },
                new Restaurant { Name = "Kalalah", City = "Örebro", Country = "Sverige", 
                    Reviews = new List<RestaurantReview> 
                    { new RestaurantReview{Rating = 4, Body = "Great food!", ReviewerName = "Robert"}}
                },
                new Restaurant { Name = "Milan", City = "Halmstad", Country = "Sverige", 
                    Reviews = new List<RestaurantReview> { new RestaurantReview{Rating = 7, Body = "Great food!", ReviewerName = "Lena"}} 
                });
            for (int i = 0; i < 1000; i++)
            {
                context.Restaurants.AddOrUpdate(r => r.Name,
                    new Restaurant { Name = i.ToString(), City = "Ingenstans", Country = "Sverige" });
            }
        }
    }
}
