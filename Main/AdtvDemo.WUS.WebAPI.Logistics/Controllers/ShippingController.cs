using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AdtvDemo.WUS.WebAPI.Logistics.Models;

namespace AdtvDemo.WUS.WebAPI.Logistics.Controllers
{
    public class ShippingController : ApiController
    {
        /// <summary>
        /// Dispatches order 
        /// </summary>
        /// <param name="request">Dispatch request</param>
        /// <returns>identity to track order</returns>
        /// <response code="200">If if found</response>
        /// <response code="404">If not found</response>
        /// <response code="500">Internal Server Error</response>
        [Route("api/Shipping/DispatchOrder")]
        [HttpPost]
        public string DispatchOrder([FromBody] DispatchRequest request)
        {
            return Guid.NewGuid().ToString();
        }

       /// <summary>
       /// Tracking API to verify where product located
       /// </summary>
       /// <param name="orderId">Order to track</param>
        /// <returns>Order status object confirming stage</returns>
        /// <response code="200">If if found</response>
        /// <response code="404">If not found</response>
        /// <response code="500">Internal Server Error</response>
        [Route("api/Shipping/WheresMyOrder")]
         [HttpGet]
        public DispatchedOrderStatus WheresMyOrder(int orderId)
        {
            return new DispatchedOrderStatus() { OrderId = orderId, CurrentStatus = "Stuck at the depot" };
        }

    }
}
