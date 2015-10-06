namespace AdtvDemo.WUS.API.Orders.Models
{
    using System.Collections.Generic;

    public class OrderDTO
    {
        public int OrderID { get; set; }
        public string DispatchID { get; set; }
        public class ProductDetail
        {
            public int ProductID { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }
        }
        public IEnumerable<ProductDetail> ProductDetails { get; set; }
    }
}