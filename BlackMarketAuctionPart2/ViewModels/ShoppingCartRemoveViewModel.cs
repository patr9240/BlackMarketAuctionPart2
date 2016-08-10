using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackMarketAuctionPart2.Models;

/*
     ShoppingCartRemoveViewModel.cs
     Austin Cameron - Patrick Ross - Ryan Jameson
     Black Market Auction House
     This is the shopping cart remove view model for the website
*/

namespace BlackMarketAuctionPart2.ViewModels
{
    class ShoppingCartRemoveViewModel
    {
        public virtual string Message { get; set; }
        public virtual decimal CartTotal { get; set; }
        public virtual int CartCount { get; set; }
        public virtual int ItemCount { get; set; }
        public virtual int DeleteID { get; set; }
    }
}
