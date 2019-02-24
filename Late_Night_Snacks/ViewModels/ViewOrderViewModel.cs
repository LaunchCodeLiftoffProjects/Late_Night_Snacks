using Late_Night_Snacks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Late_Night_Snacks.ViewModels
{
    public class ViewOrderViewModel
    {
        public Order Order { get; set; }
        public IList<OrderMenuItem> MenuItems { get; set; }
    }
}
