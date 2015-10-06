using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdtvDemo.WUS.API.Products.Models
{
    /// <summary>
    /// Product
    /// </summary>
    public class ProductDTO
    {
         public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductDetail
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
    }

    public class Products
    {
        
       
        public IEnumerable<ProductDetail> ProductDetails { get; set; }
    }
}