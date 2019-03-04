using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Late_Night_Snacks.Models
{
    public class Item
    {
        public int Id { get; set; }
        public MenuItem MenuItem { get; set; }

        public int Quantity { get; set; }
    }
}
