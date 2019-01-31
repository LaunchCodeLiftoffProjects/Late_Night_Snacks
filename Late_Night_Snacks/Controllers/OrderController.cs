using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Late_Night_Snacks.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Late_Night_Snacks.Controllers
{
    public class OrderController : Controller
    {
        private MenuItemsDbContext context;

        public OrderController(MenuItemsDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

    }
}
