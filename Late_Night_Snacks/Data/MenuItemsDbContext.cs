using Late_Night_Snacks.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Late_Night_Snacks.Data
{
    public class MenuItemsDbContext : DbContext
    {
        public DbSet<MenuItem> MenuItems { get; set; }

        public MenuItemsDbContext(DbContextOptions<MenuItemsDbContext> options)
            : base(options)
        { }
    }
}
