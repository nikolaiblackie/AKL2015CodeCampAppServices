using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using AdtvDemo.WUS.API.Orders.Models;

namespace AdtvDemo.WUS.API.Orders.Controllers
{
    public class OrderController : ApiController
    {
        /// <summary>
        /// This accepts and order
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        /// <response code="200">If if found</response>
        /// <response code="404">If not found</response>
        /// <response code="500">Internal Server Error</response>
        [HttpPost]
        [ResponseType(typeof(string))]
        public string SubmitOrder(OrderDTO order)
        {
            return Guid.NewGuid().ToString();
        }
    }
}
