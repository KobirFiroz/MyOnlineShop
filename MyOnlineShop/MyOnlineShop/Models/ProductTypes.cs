using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MyOnlineShop.Models
{
    public class ProductTypes
    {
        public int Id { set; get; } 
        [Required]
        [Display (Name="Product Type")]
        public string ProductType { set; get; }  
    }
}
