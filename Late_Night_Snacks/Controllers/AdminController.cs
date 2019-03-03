using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Late_Night_Snacks.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Late_Night_Snacks.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        public class MenuController : Controller
        {
            private MenuItemsDbContext context;

            public MenuController(MenuItemsDbContext dbContext)
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
}

