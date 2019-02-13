using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Late_Night_Snacks.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Late_Night_Snacks.Controllers
{
    public class CalendarController : Controller
    {
        private MenuDbContext context;

        public CalendarController(MenuDbContext dbContext)
        {
            context = dbContext;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }   

        //public JsonResult GetEvents()
        //{
        //    return View();
        //}
            
    }
}
