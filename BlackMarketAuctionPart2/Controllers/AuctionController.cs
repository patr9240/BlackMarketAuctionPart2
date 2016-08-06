using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using BlackMarketAuctionPart2.Models;

/*
     AuctionController.cs
     Austin Cameron - Patrick Ross - Ryan Jameson
     Black Market Auction House
     This is the auction list controller

*/

namespace BlackMarketAuctionPart2.Controllers
{
    public class AuctionController : Controller
    {
        private AuctionContext AuctionDB = new AuctionContext();

        // GET: Menu
        public ActionResult Index()
        {
            List<Category> categories = AuctionDB.Categories.ToList();
            return View(categories);
        }

        // GET: Menu/Details/5
        public ActionResult Browse(string categories = "Mounts")
        {
            // Retrieve the Category and its Associated items from database
            Category categoryModel = AuctionDB.Categories.Include("Items").Single(g => g.Name == categories);

            return View(categoryModel);
        }
        public ActionResult Details(int id = 1)
        {
            Item item = AuctionDB.Items.Find(id);

            return View(item);
        }

    }
}
