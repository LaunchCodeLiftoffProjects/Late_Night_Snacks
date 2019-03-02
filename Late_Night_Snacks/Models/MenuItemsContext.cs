using Late_Night_Snacks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Late_Night_Snacks.Data
{
    public class MenuItemsContext : DbContext
    {
        public MenuItemsContext(DbContextOptions<MenuItemsContext> options)
             : base(options)
        {

        }
        public DbSet<MenuItem> MenuItems { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CartItem> ShoppingCartItems { get; set; }

        //public DbSet<Order> Orders { get; set; }
        //public DbSet<OrderMenuItem> OrderMenuItem { get; set; }


    }
}

        