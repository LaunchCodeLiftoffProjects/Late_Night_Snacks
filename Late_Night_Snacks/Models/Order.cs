using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Late_Night_Snacks.Models
{
    public class Order
    {
        public int Id { get; set; }

        public string CustomerName { get; set; }

        public List<MenuItem> MenuItems { get; set; }
    }
}
