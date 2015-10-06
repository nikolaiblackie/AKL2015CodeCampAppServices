using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdtvDemo.WUS.WebAPI.Logistics.Models
{
    public class DispatchRequest
    {
        public string DispatchId { get; set; }
        public int OrderId { get; set; }
        public string DeliverName { get; set; }
        public string DeliverAddress { get; set; }
            
    }
}