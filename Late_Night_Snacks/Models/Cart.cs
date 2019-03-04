using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Late_Night_Snacks.Models
{
    public class Cart
    {

        [Key]
        public int RecordId { get; set; }
        public string CartId { get; set; }
        public int MenuItemId { get; set; }
        public int Count { get; set; }
        public DateTime DateCreated { get; set; }
        public virtual MenuItem MenuItem { get; set; }

    }
}
