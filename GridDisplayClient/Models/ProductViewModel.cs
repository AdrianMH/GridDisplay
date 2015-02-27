using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GridDisplayClient.Models
{
    public class ProductViewModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int[] CategoriesId { get; set; } 
    }
}