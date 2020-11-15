using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace StoreApp.Models
{
    public class BrandViewModel
    {
        [Required(ErrorMessage = "Brand is required")]
        public int BrandId { get; set; }
        public string Name { get; set; }

    }
}