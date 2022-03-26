using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtsyBusinessMetricsAPI.Models
{

    public class Result
    {
        public long transaction_id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public decimal price { get; set; }
        public string currency_code { get; set; }
        public int quantity { get; set; }
        public string shipping_cost { get; set; }
        public long receipt_id { get; set; }
        public int listing_id { get; set; }
        public string transaction_type { get; set; }
    }


    public class EtsySale
    {
        public int count { get; set; }
        public List<Result> results { get; set; }
    }

    public class SaleCount
    {
        public int count { get; set; }
    }





}
