using EtsyBusinessMetricsAPI.Models;
using System.Collections.Generic;

namespace EtsyBusinessMetricsAPI.DataAcess
{
    public interface IPurchaseDataAccess
    {
        void CreatePurchase(CreatePurchase purchase);
        void DeleteAPurchase(int purchaseId);
        List<DetailedPurchase> GetAllPurchases();
        decimal GetTotalPurchases();
        void UpdatePurchase(UpdatePurchase purchase);
    }
}