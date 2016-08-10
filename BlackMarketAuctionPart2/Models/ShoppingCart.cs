using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlackMarketAuctionPart2.Models;
using System.Web;
using System.Web.Mvc;

/*
     ShoppingCart.cs
     Austin Cameron - Patrick Ross - Ryan Jameson
     Black Market Auction House
     This is the shopping cart model for the website
*/

namespace BlackMarketAuctionPart2.Models
{
    class ShoppingCart
    {
        AuctionContext auctionDB = new AuctionContext();

        string ShoppingCartID { get; set; }
        public const string CartSessionKey = "OrderItemID";

        public static ShoppingCart GetCart(HttpContextBase context)
        {
            var cart = new ShoppingCart();
            cart.ShoppingCartID = cart.GetCartId(context);
            return cart;
        }

        // Helper method to simplify shopping cart calls
        public static ShoppingCart GetCart(Controller controller)
        {
            return GetCart(controller.HttpContext);
        }

        public void AddToCart(Item item)
        {
            // Get the matching cart and item instances
            var cartItem = auctionDB.OrderItems.SingleOrDefault(
                c => c.OrderItemID == ShoppingCartID
                && c.ItemID == item.ItemID);

            if (cartItem == null)
            {
                // Create a new cart item if no cart item exists
                cartItem = new OrderItem
                {
                    ItemID = item.ItemID,
                    OrderItemID = ShoppingCartID,
                    Count = 1,
                    DateCreated = DateTime.Now
                };
                auctionDB.OrderItems.Add(cartItem);
            }
            else
            {
                // If the item does exist in the cart, 
                // then add one to the quantity
                cartItem.Count++;
            }
            // Save changes
            auctionDB.SaveChanges();
        }
        public int RemoveFromCart(int id)
        {
            // Get the cart
            var cartItem = auctionDB.OrderItems.Single(
                cart => cart.OrderItemID == ShoppingCartID
                && cart.RecordID == id);

            int itemCount = 0;

            if (cartItem != null)
            {
                if (cartItem.Count > 1)
                {
                    cartItem.Count--;
                    itemCount = cartItem.Count;
                }
                else
                {
                    auctionDB.OrderItems.Remove(cartItem);
                }
                // Save changes
                auctionDB.SaveChanges();
            }
            return itemCount;
        }
        public void EmptyCart()
        {
            var cartItems = auctionDB.OrderItems.Where(
                cart => cart.OrderItemID == ShoppingCartID);

            foreach (var cartItem in cartItems)
            {
                auctionDB.OrderItems.Remove(cartItem);
            }
            // Save changes
            auctionDB.SaveChanges();
        }
        public List<OrderItem> GetCartItems()
        {
            return auctionDB.OrderItems.Where(
                cart => cart.OrderItemID == ShoppingCartID).ToList();
        }
        public int GetCount()
        {
            // Get the count of each item in the cart and sum them up
            int? count = (from cartItems in auctionDB.OrderItems
                          where cartItems.OrderItemID == ShoppingCartID
                          select (int?)cartItems.Count).Sum();
            // Return 0 if all entries are null
            return count ?? 0;
        }
        public decimal GetTotal()
        {
            // Multiply item price by count of that item to get 
            // the current price for each of those items in the cart
            // sum all item price totals to get the cart total
            decimal? total = (from cartItems in auctionDB.OrderItems
                              where cartItems.OrderItemID == ShoppingCartID
                              select (int?)cartItems.Count *
                              cartItems.Item.Price).Sum();

            return total ?? decimal.Zero;
        }
        public int CreateOrder(Order order)
        {
            decimal orderTotal = 0;

            var cartItems = GetCartItems();
            // Iterate over the items in the cart, 
            // adding the order details for each
            foreach (var item in cartItems)
            {
                var orderDetail = new OrderDetail
                {
                    ItemID = item.ItemID,
                    OrderId = order.OrderId,
                    UnitPrice = item.Item.Price,
                    Quantity = item.Count
                };
                // Set the order total of the shopping cart
                orderTotal += (item.Count * item.Item.Price);

                auctionDB.OrderDetails.Add(orderDetail);

            }
            // Set the order's total to the orderTotal count
            order.Total = orderTotal;

            // Save the order
            auctionDB.SaveChanges();
            // Empty the shopping cart
            EmptyCart();
            // Return the OrderId as the confirmation number
            return order.OrderId;
        }
        // We're using HttpContextBase to allow access to cookies.
        public string GetCartId(HttpContextBase context)
        {
            if (context.Session[CartSessionKey] == null)
            {
                if (!string.IsNullOrWhiteSpace(context.User.Identity.Name))
                {
                    context.Session[CartSessionKey] =
                        context.User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.Guid class
                    Guid tempCartId = Guid.NewGuid();
                    // Send tempCartId back to client as a cookie
                    context.Session[CartSessionKey] = tempCartId.ToString();
                }
            }
            return context.Session[CartSessionKey].ToString();
        }
        // When a user has logged in, migrate their shopping cart to
        // be associated with their username
        public void MigrateCart(string userName)
        {
            var shoppingCart = auctionDB.OrderItems.Where(
                c => c.OrderItemID == ShoppingCartID);

            foreach (OrderItem item in shoppingCart)
            {
                item.OrderItemID = userName;
            }
            auctionDB.SaveChanges();
        }
    }
}
