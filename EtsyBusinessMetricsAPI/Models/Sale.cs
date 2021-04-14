using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtsyBusinessMetricsAPI.Models
{
    public class Sale
    {
        public Int64 OrderId { get; set; }
        public decimal SaleAmount { get; set; }
        public string Status { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
