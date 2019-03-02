using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Late_Night_Snacks.Models;

namespace Late_Night_Snacks.Data
{
    public static class DBSeeder
    {
        public static void SeedDB(MenuItemsContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            context.MenuItems.AddRange(
                );
            context.SaveChanges();
        }
    }
}
