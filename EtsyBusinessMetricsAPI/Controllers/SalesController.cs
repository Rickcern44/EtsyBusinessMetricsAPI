using EtsyBusinessMetricsAPI.DataAcess;
using EtsyBusinessMetricsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EtsyBusinessMetricsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalesController : ControllerBase
    {
        private ISaleDataAcess saleDataAcess;
        private IPurchaseDataAccess purchaseDataAccess;
        public SalesController(ISaleDataAcess saleDataAccess, IPurchaseDataAccess purchaseDataAccess)
        {
            this.saleDataAcess = saleDataAccess;
            this.purchaseDataAccess = purchaseDataAccess;
        }
        // GET: api/<SalesController>
        [HttpGet]
        public List<Sale> Get()
        {
            List<Sale> sales = saleDataAcess.GetAllSales();

            return sales;
        }

    }
}
