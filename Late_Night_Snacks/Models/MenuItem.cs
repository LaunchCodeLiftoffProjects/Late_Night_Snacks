using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Late_Night_Snacks.Models
{
    public class MenuItem
    {
        [ScaffoldColumn(false)]
        public int MenuItemID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        public decimal Price { get; set; }

        public int Quantity { get; set; }

      
        public int? CategoryID { get; set; }

        public virtual Category Category { get; set; }
       
        

    }
}
