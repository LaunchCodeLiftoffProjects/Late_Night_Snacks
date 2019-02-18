using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Late_Night_Snacks.Models
{
    public class MenuItem
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public int ID { get; set; }
       
        public IList<OrderMenuItem> OrderMenuItems { get; set; }

    }
}
