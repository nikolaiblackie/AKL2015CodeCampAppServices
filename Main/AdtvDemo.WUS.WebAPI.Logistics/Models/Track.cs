using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdtvDemo.WUS.WebAPI.Logistics.Models
{
    public class DispatchedOrderStatus
    {
        public int OrderId { get; set; }
        public string CurrentStatus { get; set; }
    }
}