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
        
        [Route("api/Shipping/DispatchOrder")]
        [HttpPost]
        public string DispatchOrder([FromBody] DispatchRequest request)
        {
            return Guid.NewGuid().ToString();
        }

       
        [Route("api/Shipping/WheresMyOrder")]
         [HttpGet]
        public DispatchedOrderStatus WheresMyOrder(int orderId)
        {
            return new DispatchedOrderStatus() { OrderId = orderId, CurrentStatus = "Stuck at the depot" };
        }

    }
}
