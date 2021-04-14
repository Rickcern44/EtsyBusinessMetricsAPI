using EtsyBusinessMetricsAPI.Models;
using System.Collections.Generic;

namespace EtsyBusinessMetricsAPI.DataAcess
{
    public interface IPurchaseDataAccess
    {
        void CreatePurchase(CreatePurchase purchase);
        List<DetailedPurchase> GetAllPurchases();
        decimal GetTotalPurchases();
        void UpdatePurchase(UpdatePurchase purchase);
    }
}