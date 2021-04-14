using EtsyBusinessMetricsAPI.DataAcess;
using EtsyBusinessMetricsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EtsyBusinessMetricsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private ISaleDataAcess saleDataAcess;
        private IPurchaseDataAccess purchaseDataAccess;
        public HomeController(ISaleDataAcess saleDataAccess, IPurchaseDataAccess purchaseDataAccess)
        {
            this.saleDataAcess = saleDataAccess;
            this.purchaseDataAccess = purchaseDataAccess;
        }

        /// <summary>
        /// This function calls the DB and gets tge total of all Etsy Sales.
        /// </summary>
        /// <returns>Returns the total of all Etsy Sales</returns>
        [HttpGet("Total")]
        public decimal GetTotalSales()
        {
            return saleDataAcess.GetSumOfSales();
        }

        /// <summary>
        /// This method gets the sum of the total purchases for the Main Dashboard
        /// </summary>
        /// <returns> A Decimal</returns>
        [HttpGet("TotalPurchases")]
        public decimal GetTotalPurchases()
        {
            return purchaseDataAccess.GetTotalPurchases();
        }

    }
}
