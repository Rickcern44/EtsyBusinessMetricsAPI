using EtsyBusinessMetricsAPI.DataAcess;
using EtsyBusinessMetricsAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EtsyBusinessMetricsAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private ISaleDataAcess saleDataAcess;
        private IPurchaseDataAccess purchaseDataAccess;
        public PurchaseController(ISaleDataAcess saleDataAccess, IPurchaseDataAccess purchaseDataAccess)
        {
            this.saleDataAcess = saleDataAccess;
            this.purchaseDataAccess = purchaseDataAccess;
        }
        /// <summary>
        /// This is a method to get a list of detailed purchases.
        /// </summary>
        /// <returns>Returns a list of detailed purchases which is a combination of purchases 
        /// and the supply information attahced to the purcchase</returns>
        [HttpGet]
        public List<DetailedPurchase> GetDetailedPurchases()
        {
            return purchaseDataAccess.GetAllPurchases();
        }

        // GET api/<PurchaseController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PurchaseController>
        [HttpPut("Create")]
        public ActionResult CreateNewPurchase(CreatePurchase purchase)
        {
            List<DetailedPurchase> purchaseCount = purchaseDataAccess.GetAllPurchases();

            if (purchaseCount.Count() > purchase.SupplyId)
            {
                return Conflict();
            }
            else
            {
                purchaseDataAccess.CreatePurchase(purchase);
                return Ok();
            }
            
        }

        // PUT api/<PurchaseController>/5
        [HttpPut("Update")]
        public void Put(UpdatePurchase purchase)
        {
            purchaseDataAccess.UpdatePurchase(purchase);
        }

        /// <summary>
        /// Delete a purchase by ID 
        /// </summary>
        /// <param name="purchaseId"> The PurchaseId</param>
        [HttpDelete("{purchaseId}")]
        public void Delete(int purchaseId)
        {
            purchaseDataAccess.DeleteAPurchase(purchaseId);
        }
    }
}
