using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Threading.Tasks;

namespace Late_Night_Snacks.Models
{
    public class CartItem
    {
        
            [Key]
            public string ItemId { get; set; }

            public string CartId { get; set; }

            public int Quantity { get; set; }

            public System.DateTime DateCreated { get; set; }

            public int MenuItemId { get; set; }

            public virtual MenuItem MenuItem { get; set; }

        
    }
}

