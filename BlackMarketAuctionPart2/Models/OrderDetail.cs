using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     OrderDetail.cs
     Austin Cameron - Patrick Ross - Ryan Jameson
     Black Market Auction House
     This is the order detail model for the website
*/

namespace BlackMarketAuctionPart2.Models
{
    public class OrderDetail
    {
        public virtual int OrderDetailId { get; set; }
        public virtual int Quantity { get; set; }
        public virtual decimal UnitPrice { get; set; }
        public virtual int ItemID { get; set; }
        public virtual Item Item { get; set; }
        public virtual int OrderId { get; set; }
        public virtual Order Order { get; set; }
    }
}
