namespace BlackMarketAuctionPart2.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    /*
         Configuration.cs
         Austin Cameron - Patrick Ross - Ryan Jameson
         Black Market Auction House
         This is the configuration file for the database
    */

    internal sealed class Configuration : DbMigrationsConfiguration<BlackMarketAuctionPart2.Models.AuctionContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            ContextKey = "BlackMarketAuctionPart2.Models.AuctionContext";
        }

        protected override void Seed(BlackMarketAuctionPart2.Models.AuctionContext context)
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
        }
    }
}
