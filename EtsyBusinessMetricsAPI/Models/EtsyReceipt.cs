using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EtsyBusinessMetricsAPI.Models
{




    public class Receipts
    {
        public int receipt_id { get; set; }
        //public string first_line { get; set; }
        //public string second_line { get; set; }
        //public string city { get; set; }
        //public string state { get; set; }
        //public string zip { get; set; }
        //public string formatted_address { get; set; }
        public string message_from_seller { get; set; }
        public string message_from_buyer { get; set; }
        public bool was_paid { get; set; }
        public string total_tax_cost { get; set; }
        public string total_price { get; set; }
        public string total_shipping_cost { get; set; }
        public string currency_code { get; set; }
        public string discount_amt { get; set; }
        public string etsy_coupon_discount_amt { get; set; }
        public string subtotal { get; set; }
        public string grandtotal { get; set; }
        public string adjusted_grandtotal { get; set; }
        public int shipped_date { get; set; }
        public bool is_overdue { get; set; }
        public int days_from_due_date { get; set; }

    }


    public class EtsyReceipt
    {
        public int count { get; set; }
        public List<Receipts> results { get; set; }
    }

}
