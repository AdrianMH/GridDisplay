using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GridDisplayClient.Models
{
    public class ProductViewModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public List<int> CategoriesId { get; set; } 
    }
}