using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     OrderItem.cs
     Austin Cameron - Patrick Ross - Ryan Jameson
     Black Market Auction House
     This is the order item model for the website
*/

namespace BlackMarketAuctionPart2.Models
{
    public class OrderItem
    {
        [Key]
        public virtual int RecordID { get; set; }
        public virtual string OrderItemID { get; set; }
        public virtual int Count { get; set; }
        public virtual System.DateTime DateCreated { get; set; }
        public virtual int ItemID { get; set; }
        public virtual Item Item { get; set; }
    }
}
