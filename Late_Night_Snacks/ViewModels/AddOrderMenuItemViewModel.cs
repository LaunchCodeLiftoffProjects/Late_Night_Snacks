using Late_Night_Snacks.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Late_Night_Snacks.ViewModels
{
    public class AddOrderMenuItemViewModel
    {

        [Required]
        [Display(Name = "MenuItem")]
        public int MenuItemId { get; set; }

        [Required]
        [Display(Name = "Order")]
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public List<SelectListItem> MenuItems { get; set; }

        public AddOrderMenuItemViewModel () { }

        public AddOrderMenuItemViewModel (Order order, IEnumerable<MenuItem> menuItems)
        {
            this.Order = order;
            this.OrderId = order.OrderId;

            MenuItems = new List<SelectListItem>();

            foreach (var menuItem in menuItems)
            {
                MenuItems.Add(new SelectListItem
                {
                    Value = menuItem.MenuItemId.ToString(),
                    Text = menuItem.Name
                });
            }
        }

    }
}
