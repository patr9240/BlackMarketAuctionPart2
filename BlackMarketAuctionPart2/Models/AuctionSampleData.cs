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
    public class AuctionSampleData :  DropCreateDatabaseIfModelChanges<AuctionContext>
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
                new Item { Name = "Zulian Tiger", Price = 1350.0M, Description = "Ferocious tiger kept by the High Priest Thekal.", ItemImage = "/Assets/Images/Auction/Items/ZulianTiger.jpg", Category = Categories.Single(c => c.Name == "Mounts"), ItemLink = "http://www.wowhead.com/item=19902/swift-zulian-tiger" },
                new Item { Name = "Invincible", Price = 9999.9M, Description = "The mighty steed of Arthas Menethil.", ItemImage = "/Assets/Images/Auction/Items/Invincible.jpg", Category = Categories.Single(c => c.Name == "Mounts"), ItemLink = "http://www.wowhead.com/item=50818/invincibles-reins" },
                new Item { Name = "Raven Lord", Price = 1549.99M, Description = "Elegant lord of ravens to take you anywhere.", ItemImage = "/Assets/Images/Auction/Items/RavenLord.jpg", Category = Categories.Single(c => c.Name == "Mounts"), ItemLink = "http://www.wowhead.com/item=32768/reins-of-the-raven-lord" },
                new Item { Name = "Wooly Rhino", Price = 1149M, Description = "Soft and warm rhino, don't be tempted to cuddle with it!", ItemImage = "/Assets/Images/Auction/Items/WoolyRhino.jpg", Category = Categories.Single(c => c.Name == "Mounts"), ItemLink = "http://www.wowhead.com/item=54068/wooly-white-rhino" },
                new Item { Name = "Experiment 12-B", Price = 899M, Description = "Experimental drake created from the tinkering of Goblins.", ItemImage = "/Assets/Images/Auction/Items/Experiment12B.jpg", Category = Categories.Single(c => c.Name == "Mounts"), ItemLink = "http://www.wowhead.com/item=78919/experiment-12-b" },
                new Item { Name = "Riding Turtle", Price = 450M, Description = "Slow and steady may not win the race, but you'll get there! Eventually…", ItemImage = "/Assets/Images/Auction/Items/RidingTurtle.jpg", Category = Categories.Single(c => c.Name == "Mounts"), ItemLink = "http://www.wowhead.com/item=23720/riding-turtle" },
                new Item { Name = "Polar Bear", Price = 675M, Description = "Ride in style on a ferocious polar bear!", ItemImage = "/Assets/Images/Auction/Items/PolarBear.jpg", Category = Categories.Single(c => c.Name == "Mounts"), ItemLink = "http://www.wowhead.com/item=43962/reins-of-the-white-polar-bear" },
                new Item { Name = "Al'ar", Price = 925M, Description = "Favourite pet of Kael'Thas Sunstrider, said to be immortal.", ItemImage = "/Assets/Images/Auction/Items/Alar.jpg", Category = Categories.Single(c => c.Name == "Mounts"), ItemLink = "http://www.wowhead.com/item=32458/ashes-of-alar" },
                new Item { Name = "Flametalon", Price = 678M, Description = "Flaming bird to ride on as you vanquish the enemy.", ItemImage = "/Assets/Images/Auction/Items/Flametalon.jpg", Category = Categories.Single(c => c.Name == "Mounts"), ItemLink = "http://www.wowhead.com/item=71665/flametalon-of-alysrazor" },
                //Pets
                new Item { Name = "Spectal Tiger Cub", Price = 560.0M, Description = "Affectionate and curious spectral kitten.", ItemImage = "/Assets/Images/Auction/Items/TigerCub.jpg", Category = Categories.Single(c => c.Name == "Pets"), ItemLink = "http://www.wowhead.com/item=49343/spectral-tiger-cub" },
                new Item { Name = "Hippogryph Hatchling", Price = 267.0M, Description = "Orphaned Hippogryph cared for by the Druids.", ItemImage = "/Assets/Images/Auction/Items/HippogryphHatchling.jpg", Category = Categories.Single(c => c.Name == "Pets"), ItemLink = "http://www.wowhead.com/item=23713/hippogryph-hatchling" },
                new Item { Name = "Elwynn Lamb", Price = 155M, Description = "Cute lamb to help you count when trying to go to sleep!", ItemImage = "/Assets/Images/Auction/Items/ElwynnLamb.jpg", Category = Categories.Single(c => c.Name == "Pets"), ItemLink = "http://www.wowhead.com/item=44974/elwynn-lamb" },
                new Item { Name = "Son of Animus", Price = 238M, Description = "Son of the mighty  Animus Golem.", ItemImage = "/Assets/Images/Auction/Items/Animus.jpg", Category = Categories.Single(c => c.Name == "Pets"), ItemLink = "http://www.wowhead.com/item=94152/son-of-animus" },
                new Item { Name = "Ji-Kun Hatchling", Price = 179M, Description = "Cute hatchling from the great Ji-Kun.", ItemImage = "/Assets/Images/Auction/Items/Jikun.jpg", Category = Categories.Single(c => c.Name == "Pets"), ItemLink = "http://www.wowhead.com/item=94835/ji-kun-hatchling" },
                new Item { Name = "Enchanted Broom", Price = 129M, Description = "More then just a broom, this will sweep by itself!", ItemImage = "/Assets/Images/Auction/Items/EnchantedBroom.jpg", Category = Categories.Single(c => c.Name == "Pets"), ItemLink = "http://www.wowhead.com/item=44982/enchanted-broom" },
                new Item { Name = "Scorpion", Price = 76M, Description = "Captured from Durotar, watch out it still has a stinger!", ItemImage = "/Assets/Images/Auction/Items/Scorpion.jpg", Category = Categories.Single(c => c.Name == "Pets"), ItemLink = "http://www.wowhead.com/item=44973/durotar-scorpion" },
                new Item { Name = "Quivering Blob", Price = 220M, Description = "A blob of who knows what, I think it's alive?", ItemImage = "/Assets/Images/Auction/Items/Blob.jpg", Category = Categories.Single(c => c.Name == "Pets"), ItemLink = "http://www.wowhead.com/item=97960/dark-quivering-blob" },
                //Armour
                new Item { Name = "FrostFire Regalia", Price = 1200.0M, Description = "Frosty armour to keep you safe.", ItemImage = "/Assets/Images/Auction/Items/FrostFireRegalia.jpg", Category = Categories.Single(c => c.Name == "Armour"), ItemLink = "http://www.wowhead.com/item-set=526/frostfire-regalia" },
                new Item { Name = "Redemption Armour", Price = 1439.0M, Description = "Redeem yourself with this protective plate armour.", ItemImage = "/Assets/Images/Auction/Items/RedemptionArmour.jpg", Category = Categories.Single(c => c.Name == "Armour"), ItemLink = "http://www.wowhead.com/item-set=528/redemption-armor" },
                new Item { Name = "Dreadnaught's Battlegear", Price = 1566M, Description = "Strike terror into your foes hearts with this threatening armour!", ItemImage = "/Assets/Images/Auction/Items/Dreadnaughts.jpg", Category = Categories.Single(c => c.Name == "Armour"), ItemLink = "http://www.wowhead.com/transmog-set=688/dreadnaughts-battlegear" },
                //Weapons
                new Item { Name = "Lute of the Phoenix King", Price = 7500.0M, Description = "Bust some riffs, or slay all that stand in your path.", ItemImage = "/Assets/Images/Auction/Items/SunLute.jpg", Category = Categories.Single(c => c.Name == "Weapons"), ItemLink = "http://www.wowhead.com/item=44924/sun-lute-of-the-phoenix-king" },
                new Item { Name = "Arcanite Ripper", Price = 4600.0M, Description = "Bust some riffs, or slay all that stand in your path.", ItemImage = "/Assets/Images/Auction/Items/ArcaniteRipper.jpg", Category = Categories.Single(c => c.Name == "Weapons"), ItemLink = "http://www.wowhead.com/item=39769/arcanite-ripper" },
                new Item { Name = "Atiesh Staff", Price = 9799.0M, Description = "The legendary Atiesh Staff, all for you!.", ItemImage = "/Assets/Images/Auction/Items/AtieshStaff.jpg", Category = Categories.Single(c => c.Name == "Weapons"), ItemLink = "http://www.wowhead.com/item=22589/atiesh-greatstaff-of-the-guardian" },
                new Item { Name = "Dragon Wrath", Price = 2789.0M, Description = "Wield the wrath of the dragons with this powerful staff!", ItemImage = "/Assets/Images/Auction/Items/DragonWrath.jpg", Category = Categories.Single(c => c.Name == "Weapons"), ItemLink = "http://www.wowhead.com/item=71086/dragonwrath-tarecgosas-rest" },
                new Item { Name = "Thori'Dal", Price = 1277.0M, Description = "Shoot magical arrows to pierce your foes!", ItemImage = "/Assets/Images/Auction/Items/Thoridal.jpg", Category = Categories.Single(c => c.Name == "Weapons"), ItemLink = "http://www.wowhead.com/item=34334/thoridal-the-stars-fury" },
                new Item { Name = "Val'Anyr", Price = 2469.0M, Description = "The power of creation courses through this mace.", ItemImage = "/Assets/Images/Auction/Items/Valanyr.jpg", Category = Categories.Single(c => c.Name == "Weapons"), ItemLink = "http://www.wowhead.com/item=46017/valanyr-hammer-of-ancient-kings" },
                
                //Toys
                new Item { Name = "Foam Sword Rack", Price = 10.0M, Description = "Foam Sword Fight!", ItemImage = "/Assets/Images/Auction/Items/FoamSwordRack.jpg", Category = Categories.Single(c => c.Name == "Toys"), ItemLink = "http://www.wowhead.com/item=45063/foam-sword-rack" },
                new Item { Name = "Imp in a Ball", Price = 10.0M, Description = "Ask the Imp a question, I'm sure you'll like his answer.", ItemImage = "/Assets/Images/Auction/Items/ImpInABall.jpg", Category = Categories.Single(c => c.Name == "Toys"), ItemLink = "http://www.wowhead.com/item=32542/imp-in-a-ball" },
                new Item { Name = "Ogre Pinata", Price = 67M, Description = "If you can't kill real ogres, kill this! Plus you get candy.", ItemImage = "/Assets/Images/Auction/Items/OgrePinata.jpg", Category = Categories.Single(c => c.Name == "Toys"), ItemLink = "http://www.wowhead.com/item=46780/ogre-pinata" },
                new Item { Name = "FishingChair", Price = 148M, Description = "Set up a comfy fishing chair where ever you go!", ItemImage = "/Assets/Images/Auction/Items/FishingChair.jpg", Category = Categories.Single(c => c.Name == "Toys"), ItemLink = "http://www.wowhead.com/item=33223/fishing-chair" },
                new Item { Name = "Paper Flying Kit", Price = 35M, Description = "Annoy your foes with a paper flying machine!", ItemImage = "/Assets/Images/Auction/Items/PaperKit.jpg", Category = Categories.Single(c => c.Name == "Toys"), ItemLink = "http://www.wowhead.com/item=34499/paper-flying-machine-kit" },
                new Item { Name = "Weather Machine", Price = 379M, Description = "Are you happy on a rainy day? Change the weather with this machine!", ItemImage = "/Assets/Images/Auction/Items/WeatherMachine.jpg", Category = Categories.Single(c => c.Name == "Toys"), ItemLink = "http://www.wowhead.com/item=35227/goblin-weather-machine-prototype-01-b" },
                //Tabards
                new Item { Name = "Tabard of Brilliance", Price = 65.0M, Description = "Show everyone how brilliant you are!", ItemImage = "/Assets/Images/Auction/Items/TabardBrilliance.jpg", Category = Categories.Single(c => c.Name == "Tabards"), ItemLink = "http://www.wowhead.com/item=38312/tabard-of-brilliance" },
                new Item { Name = "Tabard of Frost", Price = 65.0M, Description = "Show everyone how frosty you are!", ItemImage = "/Assets/Images/Auction/Items/TabardFrost.jpg", Category = Categories.Single(c => c.Name == "Tabards"), ItemLink = "http://www.wowhead.com/item=23709/tabard-of-frost" },
                new Item { Name = "Tabard of the Defender", Price = 65M, Description = "Show everyone how defensive you are!", ItemImage = "/Assets/Images/Auction/Items/TabardDefender.jpg", Category = Categories.Single(c => c.Name == "Tabards"), ItemLink = "http://www.wowhead.com/item=38314/tabard-of-the-defender" },
                new Item { Name = "Tabard of Nature", Price = 65M, Description = "Show everyone how much of a hippy you are!", ItemImage = "/Assets/Images/Auction/Items/TabardNature.jpg", Category = Categories.Single(c => c.Name == "Tabards"), ItemLink = "http://www.wowhead.com/item=38309/tabard-of-nature" },
                new Item { Name = "Tabard of Fury", Price = 65M, Description = "show everyone your inner fury!", ItemImage = "/Assets/Images/Auction/Items/TabardFury.jpg", Category = Categories.Single(c => c.Name == "Tabards"), ItemLink = "http://www.wowhead.com/item=38313/tabard-of-fury" },
                new Item { Name = "Tabard of the Void", Price = 65M, Description = "Show everyone your allegiance to the void!", ItemImage = "/Assets/Images/Auction/Items/TabardVoid.jpg", Category = Categories.Single(c => c.Name == "Tabards"), ItemLink = "http://www.wowhead.com/item=38311/tabard-of-the-void" },
                //Mystery
                new Item { Name = "Mysterious Black Market Container", Price = 10.0M, Description = "A chest filled with goodies... Or not.", ItemImage = "/Assets/Images/Auction/Items/UnclaimedContainer.jpg", Category = Categories.Single(c => c.Name == "Mystery"), ItemLink = "http://www.wowhead.com/item=97565/unclaimed-black-market-container" }

            }.ForEach(i => context.Items.Add(i));
        }
    }
}