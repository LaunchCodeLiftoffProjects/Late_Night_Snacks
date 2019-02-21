using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Late_Night_Snacks.ViewModels
{
    public class AddOrderViewModel
    {

        [Required]
        [Display(Name ="Customer Name")]
        public string CustomerName { get; set; }

        public int Id { get; set; }
    }
}
