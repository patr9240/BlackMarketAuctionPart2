using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

/*
     AuctionSampleData.cs
     Austin Cameron - Patrick Ross - Ryan Jameson
     Black Market Auction House
     This is the sample data for the website

*/

namespace BlackMarketAuctionPart2.Models
{
    public class AuctionSampleData : DropCreateDatabaseIfModelChanges<AuctionContext>
    {

        protected override void Seed(AuctionContext context)
        {
            var Categories = new List<Category>
            {
                new Category { Name = "Mounts", Description = "The rarest of rideable companions.", ThumbnailImage = "/Assets/Images/Auction/Categories/Mounts.jpg" },
                new Category { Name = "Pets", Description = "A campanion to follow you around.", ThumbnailImage = "/Assets/Images/Auction/Categories/Pets.jpg" },
                new Category { Name = "Armour", Description = "Splendid armour for any occasion.", ThumbnailImage = "/Assets/Images/Auction/Categories/Armours.jpg" },
                new Category { Name = "Weapons", Description = "Powerful objects to bring your foes demise.", ThumbnailImage = "/Assets/Images/Auction/Categories/Weapons.jpg" },
                new Category { Name = "Toys", Description = "Great items to grant amusement.", ThumbnailImage = "/Assets/Images/Auction/Categories/Toys.jpg" },
                new Category { Name = "Tabards", Description = "Spice up your fashion statement.", ThumbnailImage = "/Assets/Images/Auction/Categories/Tabards.jpg" },
                new Category { Name = "Mystery", Description = "We cannot gaurantee what lies within...", ThumbnailImage = "/Assets/Images/Auction/Categories/Mysterious.jpg" },
            };

            new List<Item>
            {
                //Mounts
                new Item { Name = "Zulian Tiger", Price = 10.0M, Description = "Ferocious tiger kept by the High Priest Thekal.", ItemImage = "/Assets/Images/Auction/Items/ZulianTiger.jpg", Category = Categories.Single(c => c.Name == "Mounts"), ItemLink = "http://www.wowhead.com/item=19902/swift-zulian-tiger" },
                new Item { Name = "Invincible", Price = 100.0M, Description = "The mighty steed of Arthas Menethil.", ItemImage = "/Assets/Images/Auction/Items/Invincible.jpg", Category = Categories.Single(c => c.Name == "Mounts"), ItemLink = "http://www.wowhead.com/item=50818/invincibles-reins" },
                //Pets
                new Item { Name = "Spectal Tiger Cub", Price = 10.0M, Description = "Affectionate and curious spectral kitten.", ItemImage = "/Assets/Images/Auction/Items/TigerCub.jpg", Category = Categories.Single(c => c.Name == "Pets"), ItemLink = "http://www.wowhead.com/item=49343/spectral-tiger-cub" },
                new Item { Name = "Hippogryph Hatchling", Price = 10.0M, Description = "Orphaned Hippogryph cared for by the Druids.", ItemImage = "/Assets/Images/Auction/Items/HippogryphHatchling.jpg", Category = Categories.Single(c => c.Name == "Pets"), ItemLink = "http://www.wowhead.com/item=23713/hippogryph-hatchling" },
                //Armour
                new Item { Name = "FrostFire Regalia", Price = 10.0M, Description = "Frosty armour to keep you safe.", ItemImage = "/Assets/Images/Auction/Items/FrostFireRegalia.jpg", Category = Categories.Single(c => c.Name == "Armour"), ItemLink = "http://www.wowhead.com/item-set=526/frostfire-regalia" },
                new Item { Name = "Redemption Armour", Price = 10.0M, Description = "Redeem yourself with this protective plate armour.", ItemImage = "/Assets/Images/Auction/Items/RedemptionArmour.jpg", Category = Categories.Single(c => c.Name == "Armour"), ItemLink = "http://www.wowhead.com/item-set=528/redemption-armor" },
                //Weapons
                new Item { Name = "Sun-Lute of the Phoenix King", Price = 10.0M, Description = "Bust some riffs, or slay all that stand in your path.", ItemImage = "/Assets/Images/Auction/Items/SunLute.jpg", Category = Categories.Single(c => c.Name == "Weapons"), ItemLink = "http://www.wowhead.com/item=44924/sun-lute-of-the-phoenix-king" },
                new Item { Name = "Arcanite Ripper", Price = 10.0M, Description = "Bust some riffs, or slay all that stand in your path.", ItemImage = "/Assets/Images/Auction/Items/ArcaniteRipper.jpg", Category = Categories.Single(c => c.Name == "Weapons"), ItemLink = "http://www.wowhead.com/item=39769/arcanite-ripper" },
                //Toys
                new Item { Name = "Foam Sword Rack", Price = 10.0M, Description = "Foam Sword Fight!", ItemImage = "/Assets/Images/Auction/Items/FoamSwordRack.jpg", Category = Categories.Single(c => c.Name == "Toys"), ItemLink = "http://www.wowhead.com/item=45063/foam-sword-rack" },
                new Item { Name = "Imp in a Ball", Price = 10.0M, Description = "Ask the Imp a question, I'm sure you'll like his answer.", ItemImage = "/Assets/Images/Auction/Items/ImpInABall.jpg", Category = Categories.Single(c => c.Name == "Toys"), ItemLink = "http://www.wowhead.com/item=32542/imp-in-a-ball" },
                //Tabards
                new Item { Name = "Tabard of Brilliance", Price = 10.0M, Description = "Show everyone how brilliant you are!", ItemImage = "/Assets/Images/Auction/Items/TabardBrilliance.jpg", Category = Categories.Single(c => c.Name == "Tabards"), ItemLink = "http://www.wowhead.com/item=38312/tabard-of-brilliance" },
                new Item { Name = "Tabard of Frost", Price = 10.0M, Description = "Show everyone how frosty you are!", ItemImage = "/Assets/Images/Auction/Items/TabardFrost.jpg", Category = Categories.Single(c => c.Name == "Tabards"), ItemLink = "http://www.wowhead.com/item=23709/tabard-of-frost" },
                //Mystery
                new Item { Name = "Mysterious Black Market Container", Price = 10.0M, Description = "A chest filled with goodies... Or not.", ItemImage = "/Assets/Images/Auction/Items/UnclaimedContainer.jpg", Category = Categories.Single(c => c.Name == "Mystery"), ItemLink = "http://www.wowhead.com/item=97565/unclaimed-black-market-container" }

            }.ForEach(i => context.Items.Add(i));
        }
    }
}