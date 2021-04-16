using EtsyBusinessMetricsAPI.DataAcess;
using EtsyBusinessMetricsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
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
        private readonly IConfiguration _configuration;
        public HomeController(ISaleDataAcess saleDataAccess, IPurchaseDataAccess purchaseDataAccess, IConfiguration configuration)
        {
            this.saleDataAcess = saleDataAccess;
            this.purchaseDataAccess = purchaseDataAccess;
            _configuration = configuration;
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
        /// Get the API key 
        /// </summary>
        /// <returns>The API key</returns>
        [HttpGet("Api")]
        public string GetApiKey()
        {
            return _configuration.GetSection("EtsyApi:Key").Value;
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
