using Late_Night_Snacks.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Late_Night_Snacks.ViewModels
{
    public class OrderViewModel
    {

        [Required]
        public string CustomerName { get; set; }

        public int ID { get; set; }

        public List<MenuItem> MenuItems { get; set; }

    }
}
