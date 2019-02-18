using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Late_Night_Snacks.Models
{
    public class OrderMenuItem
    {

        public int OrderId { get; set; }
        public Order Order { get; set; }

        public int MenuItemId { get; set; }
        public MenuItem MenuItem {get; set;}

    }
}
