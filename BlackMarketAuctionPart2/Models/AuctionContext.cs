namespace BlackMarketAuctionPart2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    /*
         AuctionContext.cs
         Austin Cameron - Patrick Ross - Ryan Jameson
         Black Market Auction House
         This is the model context of the site.

    */

    public partial class AuctionContext : DbContext
    {
        public AuctionContext()
            : base("name=AuctionConnection")
        {
        }

        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Item> Items { get; set; }
    }
}
