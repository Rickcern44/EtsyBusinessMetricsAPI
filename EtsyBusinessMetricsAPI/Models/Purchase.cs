using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtsyBusinessMetricsAPI.Models
{
    public class Purchase
    {
        public int PurchaseId { get; set; }
        public DateTime PurchaseDate { get; set; }
        public int SupplyId { get; set; }
    }
    public class UpdatePurchase
    {
        public int PurchaseId { get; set; }
        public int SupplyId { get; set; }
    }
    public class CreatePurchase
    {
        public DateTime purchaseDate { get; set; }
        public int SupplyId { get; set; }
    }
}
