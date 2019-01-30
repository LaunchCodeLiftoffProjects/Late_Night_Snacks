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
            ViewBag.MenuItems = context.MenuItems.ToList();
            return View();
        }

        public IActionResult AddMenu()
        {
            AddMenuViewModel addMenuViewModel =
                new AddMenuViewModel();
            return View(addMenuViewModel);
        }

        [HttpPost]
        public IActionResult AddMenu(AddMenuViewModel addMenuViewModel)
        {
            if (ModelState.IsValid)
            {
                MenuItem newItem = new MenuItem()
                {
                    Name = addMenuViewModel.Name,
                    Description = addMenuViewModel.Description,
                    Price = addMenuViewModel.Price,
                    Quantity = addMenuViewModel.Quantity, 
                    
                };
                context.MenuItems.Add(newItem);
                context.SaveChanges();
                return Redirect("Index");
            }
           
            return View(addMenuViewModel);
        }

        public IActionResult Remove()
        {
            ViewBag.title = "Remove Menu.";
            ViewBag.MenuItems = context.MenuItems.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Remove(int[] menuIds)
        {
            foreach(int menuId in menuIds)
            {
                MenuItem theItem = context.MenuItems.Single(x => x.ID == menuId);
                context.MenuItems.Remove(theItem);
            }
            context.SaveChanges();
            return Redirect("/");
        }
    }
}
