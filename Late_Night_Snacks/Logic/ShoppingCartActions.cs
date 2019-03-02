using Late_Night_Snacks.Data;
using Late_Night_Snacks.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Late_Night_Snacks.Logic
{
        public class ShoppingCartActions : IDisposable
        {
            public string ShoppingCartId { get; set; }
            public MenuItemsContext = new MenuItemsContext();

            public const string TraceIdentifier = "TraceIdentifier";

            public void AddToCart(int id)
            {
                // Retrieve the product from the database.           
                ShoppingCartId = GetCartId();

                var cartItem = Db.ShoppingCartItems.SingleOrDefault(
                    c => c.CartId == ShoppingCartId
                    && c.MenuItemId == id);
                if (cartItem == null)
                {
                    // Create a new cart item if no cart item exists.                 
                    cartItem = new CartItem
                    {
                        ItemId = Guid.NewGuid().ToString(),
                        MenuItemId = id,
                        CartId = ShoppingCartId,
                        MenuItem = Db.MenuItems.SingleOrDefault(
                       p => p.MenuItemID == id),
                        Quantity = 1,
                        DateCreated = DateTime.Now
                    };

                    Db.ShoppingCartItems.Add(cartItem);
                }
                else
                {
                    // If the item does exist in the cart,                  
                    // then add one to the quantity.                 
                    cartItem.Quantity++;
                }
                Db.SaveChanges();
            }

            public void Dispose()
            {
                if (Db != null)
                {
                    Db.Dispose();
                    Db = null;
                }
            }

            public string GetCartId()
            {
                if (!HttpContext.TraceIdentifier)
                {
                    return HttpContext.Session.ToString();
                }
                if (!string.IsNullOrWhiteSpace(HttpContext.User))
                {
                    HttpContext.Current.Session[CartSessionKey] = HttpContext.Current.User.Identity.Name;
                }
                else
                {
                    // Generate a new random GUID using System.Guid class.     
                    Guid tempCartId = Guid.NewGuid();
                    HttpContext.TraceIdentifier = tempCartId.ToString();
                }
            
            return HttpContext.ISession[CartSessionKey].ToString();
            }

            public List<CartItem> GetCartItems()
            {
                ShoppingCartId = GetCartId();

                return Db.ShoppingCartItems.Where(
                    c => c.CartId == ShoppingCartId).ToList();
            }
        }
    }
}
}
