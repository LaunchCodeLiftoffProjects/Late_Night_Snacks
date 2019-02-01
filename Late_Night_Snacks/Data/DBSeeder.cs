using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Late_Night_Snacks.Models;

namespace Late_Night_Snacks.Data
{
    public static class DBSeeder
    {
        public static void SeedDB(MenuItemsDbContext context)
        {
            context.Database.EnsureCreated();
            context.MenuItems.AddRange(
                new MenuItem()
                {
                    Name = "HotDog",
                    Description = "Foot Long",
                    Price = 1.99M,
                    Quantity = 1,
                },
                new MenuItem()
                {
                    Name = "Pepperoni Pizza",
                    Description = "Once Slice",
                    Price = 2.99M,
                    Quantity = 1,
                },
                new MenuItem()
                {
                    Name = "Hot Fudge Sunday", 
                    Description = "Vanilla", 
                    Price = 5.00M,
                    Quantity = 1
                }
                );
            context.SaveChanges();
        }
    }
}
