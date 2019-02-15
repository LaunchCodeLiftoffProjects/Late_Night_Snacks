using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Late_Night_Snacks.Data;
using Late_Night_Snacks.Models;
using Late_Night_Snacks.ViewModels;
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

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.Orders = context.Orders.ToList();
            return View();
        }


        // GET: /<controller>/
        public IActionResult CreateOrder()
        {
            ViewBag.MenuItems = context.MenuItems.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult CreateOrder(OrderViewModel orderViewModel, int[] itemsToAdd)
        {
            ViewBag.MenuItems = context.MenuItems.ToList();

            List<MenuItem> aList = new List<MenuItem>();



            foreach (int item in itemsToAdd)
            {
                aList.Add(context.MenuItems.Single(x => x.ID == item));
            }

            Order order = new Order()
            {
                MenuItems = aList,
                CustomerName = orderViewModel.CustomerName,
            };

            return RedirectToAction("Index", order);

        }


    }
}
