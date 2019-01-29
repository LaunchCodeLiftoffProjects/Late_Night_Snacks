using Late_Night_Snacks.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Late_Night_Snacks.Data
{
    public class MenuDbContext : DbContext
    {
        public DbSet<Menu> Menus { get; set; }

        public MenuDbContext(DbContextOptions<MenuDbContext> options)
            : base(options)
        { }
    }
}
