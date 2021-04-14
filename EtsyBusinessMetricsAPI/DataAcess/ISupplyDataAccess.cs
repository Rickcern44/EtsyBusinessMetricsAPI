using EtsyBusinessMetricsAPI.Models;
using System.Collections.Generic;

namespace EtsyBusinessMetricsAPI.DataAcess
{
    public interface ISupplyDataAccess
    {
        void AddASupply(Supply supply);
        void DeleteSupplyById(int supplyId);
        List<Supply> GetAllSupplies();
        int GetSupplyCount();
        void UpdateSupplyById(Supply supply);
    }
}