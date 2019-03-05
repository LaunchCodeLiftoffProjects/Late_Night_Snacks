using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Late_Night_Snacks.Data;
using Late_Night_Snacks.Models;
using Late_Night_Snacks.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Late_Night_Snacks.Controllers
{/*
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
            IList<Order> Orders = context.Orders.ToList();
            return View(Orders);
        }

        public IActionResult AddOrder()
        {
            AddOrderViewModel addOrderViewModel = new AddOrderViewModel();
            return View(addOrderViewModel);
        }
        
        [HttpPost]
        public IActionResult AddOrder(AddOrderViewModel addOrderViewModel)
        {
            if (ModelState.IsValid)
            {
                Order newOrder = new Order
                {
                    CustomerName = addOrderViewModel.CustomerName
                };

                context.Orders.Add(newOrder);
                context.SaveChanges();

                return Redirect("/Order/ViewOrder/" + newOrder.OrderId);
            }
            return View(addOrderViewModel);
        }

        public IActionResult ViewOrder(int id)
        {
            Order orderRequested = context.Orders.Single(c => c.OrderId == id);

            IList<OrderDetail> MenuItems = context.OrderDetails.Include(item => item.MenuItem).Where(c => c.OrderId == id).ToList();

            ViewOrderViewModel viewOrderViewModel = new ViewOrderViewModel
            {
                Order = orderRequested,
                MenuItems = MenuItems
            };

            return View(viewOrderViewModel);
        }

        public IActionResult AddOrderMenuItem(int id)
        {
            Order order = context.Orders.Single(c => c.OrderId == id);

            List<MenuItem> menuItems = context.MenuItems.Include(c => c.OrderDetails).ToList();

            AddOrderMenuItemViewModel addOrderMenuItemViewModel = new AddOrderMenuItemViewModel(order, menuItems);

            return View(addOrderMenuItemViewModel);
        }

        [HttpPost]
        public IActionResult AddOrderMenuItem (AddOrderMenuItemViewModel addOrderMenuItemViewModel)
        {
            if (ModelState.IsValid)
            {
                if (context.OrderDetails
                    .Where(omi => omi.MenuItemId == addOrderMenuItemViewModel.MenuItemId)
                    .Where(omi => omi.OrderId == addOrderMenuItemViewModel.OrderId)
                    .ToList().Count == 0)
                {
                    OrderDetail orderMenuItem = new OrderDetail
                    {
                        MenuItemId = addOrderMenuItemViewModel.MenuItemId,
                        OrderId = addOrderMenuItemViewModel.OrderId
                    };
                    context.OrderDetails.Add(orderMenuItem);
                    context.SaveChanges();
                }

                return Redirect("/Order/ViewOrder/" + addOrderMenuItemViewModel.OrderId);

            }

            return View(addOrderMenuItemViewModel);
        }



    }*/
}
