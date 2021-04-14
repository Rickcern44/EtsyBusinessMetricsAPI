using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtsyBusinessMetricsAPI.Models
{
    public class DetailedPurchase
    {
        public int PurchaseId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int SupplyId { get; set; }
        public string SupplyName { get; set; }
        public string SupplyType { get; set; }
        public decimal SupplyCost { get; set; }
    }
}
