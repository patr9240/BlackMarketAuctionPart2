using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     Item.cs
     Austin Cameron - Patrick Ross - Ryan Jameson
     Black Market Auction House
     This is the auction item class.

*/

namespace BlackMarketAuctionPart2.Models
{
    public class Item
    {
        /// <summary>
        /// This is the empty constrcutor
        /// </summary>
        public Item()
        {
        }
        /// <summary>
        /// This constructor takes one parameter - Name
        /// </summary>
        /// <param name="Name"></param>
        public Item(string Name)
        {
            this.Name = Name;
        }
        public virtual int ItemID { get; set; }
        public virtual int CategoryID { get; set; }
        public virtual string Name { get; set; }
        public virtual decimal Price { get; set; }
        public virtual string Description { get; set; }
        public virtual string ItemLink { get; set; }
        public virtual string ItemImage { get; set; }
        public virtual Category Category { get; set; }
    }
}
