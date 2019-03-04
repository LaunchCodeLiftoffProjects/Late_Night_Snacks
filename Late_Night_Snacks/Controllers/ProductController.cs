using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Late_Night_Snacks.Data;
using Late_Night_Snacks.Models;
using Microsoft.AspNetCore.Mvc;

namespace Late_Night_Snacks.Controllers
{
    [Route("product")]
    public class ProductController : Controller
    {
        private MenuItemsDbContext context;

        public ProductController(MenuItemsDbContext dbContext)
        {
            context = dbContext;
        }

        [Route("")]
        [Route("index")]
        [Route("~/")]
        public IActionResult Index()
        {

            ViewBag.MenuItems = context.MenuItems.ToList();
            return View();
        }
    }
}

