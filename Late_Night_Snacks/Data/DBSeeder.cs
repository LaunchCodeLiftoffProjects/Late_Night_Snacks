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
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.MenuItems.AddRange(
                new MenuItem()
                {
                    Name = "HotDog",
                    Description = "Foot Long",
                    Price = 1.00M,
                    Quantity = 1,
                },
                new MenuItem()
                {
                    Name = "Pepperoni Pizza",
                    Description = "Once Slice",
                    Price = 2.00M,
                    Quantity = 1,
                },
                new MenuItem()
                {
                    Name = "Hot Fudge Sunday", 
                    Description = "Vanilla", 
                    Price = 5.00M,
                    Quantity = 1
                },
                new MenuItem()
                {
                    Name = "Chips",
                    Description = "Salty",
                    Price = 1.00M,
                    Quantity = 1
                }, new MenuItem()
                {
                    Name = "Popcorn",
                    Description = "Kettle",
                    Price = 6.00M,
                    Quantity = 1
                }, new MenuItem()
                {
                    Name = "Funnel Cake",
                    Description = "Any Topping",
                    Price = 3.00M,
                    Quantity = 1
                }, new MenuItem()
                {
                    Name = "Cheese Burger",
                    Description = "Double Stacked",
                    Price = 5.00M,
                    Quantity = 1
                }, new MenuItem()
                {
                    Name = "Cucumber",
                    Description = "Crunchy",
                    Price = 1.00M,
                    Quantity = 1
                },
                new MenuItem()
                {
                    Name = "Strawberry Shortcake",
                    Description = "With Whip",
                    Price = 8.00M,
                    Quantity = 1
                }, new MenuItem()
                {
                    Name = "Steak and Eggs",
                    Description = "With Hashbrowns",
                    Price = 12.00M,
                    Quantity = 1
                }
                );
            context.SaveChanges();
        }
    }
}
