using CheeseMVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CheeseMVC.ViewModels
{
    public class AddMenuItemViewModel
    {
        public Menu Menu { get; set; }
        public List<SelectListItem> Cheeses { get; set; }

        public int MenuID { get; set; }
        public int CheeseID { get; set; }

        public AddMenuItemViewModel() { }

        public AddMenuItemViewModel(Menu menu, IEnumerable<Cheese> cheeses)
        {
            Cheeses = new List<SelectListItem>();
            foreach (var cheese in cheeses)
            {
                Cheeses.Add(new SelectListItem
                {
                    Value = cheese.ID.ToString(),
                    Text = cheese.Name
                });
            }
            Menu = menu;
        }
    }
}
