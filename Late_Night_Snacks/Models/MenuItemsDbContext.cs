using Late_Night_Snacks.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Late_Night_Snacks.Data
{
    public class MenuItemsDbContext : DbContext
    {
        public DbSet<MenuItem> MenuItems { get; set; }

        public DbSet<Item> Items { get; set; }

        public MenuItemsDbContext()
        {
        }
        public MenuItemsDbContext(DbContextOptions<MenuItemsDbContext> options)
            : base(options)
        {
           
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
                .HasKey(c => new { c.MenuItemId, c.OrderId });
        }

        public DbSet<Late_Night_Snacks.Models.Product> Product { get; set; }
        /*protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<MenuItem>().HasData(
                new MenuItem
                {
                    ID = -1,
                    Name = "Ribs",
                    Description = "Mouthwatering",
                    Price = 24.99M,
                    Quantity = 1,
                   
                }
            );
        }*/

    }
}
