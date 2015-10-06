namespace AdtvDemo.WUS.API.Products.Controllers
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using System.Web.Http.Description;
   
    using AdtvDemo.WUS.API.Products.Models;

    /// <summary>
    /// Products API for ordering
    /// </summary>
    public class ProductController : ApiController
    {
        

        // Project products to product DTOs.
        private ProductDTO MapProducts(int id, string name, decimal price)
        {
            return new ProductDTO() { Id = id, Name = name, Price = price };
        }
        private IEnumerable<ProductDTO> GetMockProducts()
        {
            return new List<ProductDTO>() { MapProducts(1,"API App", (decimal)20.02),
            MapProducts(2,"Logic App", (decimal)36.45),
            MapProducts(3,"Web App", (decimal)12.6),
            MapProducts(4,"Mobile App", (decimal)36.36),
            MapProducts(5,"Service Bus", (decimal)11.55)};
        }

        /// <summary>
        /// Validate Products exist
        /// </summary>
        /// <param name="productsToValidate">List ProductDetail</param>
        /// <returns>True if valid</returns>
        /// <response code="200">If products valid</response>
        /// <response code="400">If products not valid</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [Route("api/Product/ValidateProducts")]
        [ResponseType(typeof(bool))]
        public bool ValidateProducts([FromBody] IEnumerable<ProductDetail> productsToValidate)
        {
            IEnumerable<ProductDTO> products = GetMockProducts();
            foreach (var item in productsToValidate)
	        {
		        if (!products.Any(c => c.Id == item.ProductID))
                    throw new HttpResponseException(
                      Request.CreateResponse(HttpStatusCode.BadRequest, 
                      string.Format("Product {0} {1} doesn't exist", item.ProductID, item.Name))); 
	        }

            return true;
        }

        /// <summary>
        /// Gets all Products available
        /// </summary>
        /// <returns>Current List</returns>
        [HttpGet]
        [Route("api/Product/GetProducts")]
        [ResponseType(typeof(ProductDTO[]))]
        public IEnumerable<ProductDTO> GetProducts()
        {
            return GetMockProducts();
        }

        /// <summary>
        /// Gets Product by id
        /// </summary>
        /// <param name="id">id of product</param>
        /// <response code="200">If product if found</response>
        /// <response code="404">If product not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpGet]
        [ResponseType(typeof(ProductDTO))]
        public ProductDTO Get(int id)
        {
            var product = (from p in GetMockProducts()
                           where p.Id == 1
                           select p).FirstOrDefault();
            if (product == null)
            {
                throw new HttpResponseException(
                    Request.CreateResponse(HttpStatusCode.NotFound));
            }
            return product;
        }

        
    }
}