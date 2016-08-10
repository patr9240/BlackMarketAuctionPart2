using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BlackMarketAuctionPart2.Models;

/*
     ShoppingCartViewModel.cs
     Austin Cameron - Patrick Ross - Ryan Jameson
     Black Market Auction House
     This is the shopping cart view model for the website
*/

namespace BlackMarketAuctionPart2.ViewModels
{
    public class ShoppingCartViewModel
    {
        public virtual List<OrderItem> OrderItemList { get; set; }
        public virtual decimal CartTotal { get; set; }
    }
}