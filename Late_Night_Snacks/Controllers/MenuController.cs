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
        private MenuDbContext context;

        public MenuController(MenuDbContext dbContext)
        {
            context = dbContext;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            ViewBag.menus = context.Menus.ToList();
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
                Menu newItem = new Menu()
                {
                    MenuItem = addMenuViewModel.MenuItem,
                    Price = addMenuViewModel.Price
                };
                context.Menus.Add(newItem);
                context.SaveChanges();
                return Redirect("Index");
            }
           
            return View(addMenuViewModel);
        }

        public IActionResult Remove()
        {
            ViewBag.title = "Remove Menu.";
            ViewBag.menus = context.Menus.ToList();
            return View();
        }
        [HttpPost]
        public IActionResult Remove(int[] menuIds)
        {
            foreach(int menuId in menuIds)
            {
                Menu theItem = context.Menus.Single(x => x.ID == menuId);
                context.Menus.Remove(theItem);
            }
            context.SaveChanges();
            return Redirect("/");
        }
    }
}
