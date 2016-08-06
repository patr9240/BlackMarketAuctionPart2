using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
     Category.cs
     Austin Cameron - Patrick Ross - Ryan Jameson
     Black Market Auction House
     This is the Category class.

*/

namespace BlackMarketAuctionPart2.Models
{
    public class Category
    {
        /// <summary>
        /// This is the empty constructor
        /// </summary>
        public Category()
        {
        }

        /// <summary>
        /// This constructor takes one parameter - Name
        /// </summary>
        /// <param name="Name"></param>
        public Category(string Name)
        {
            this.Name = Name;
        }
        public virtual int CategoryID { get; set; }
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual string ThumbnailImage { get; set; }
        public virtual List<Item> items { get; set; }
    }
}
