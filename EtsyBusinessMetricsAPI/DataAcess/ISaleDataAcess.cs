using EtsyBusinessMetricsAPI.Models;
using System.Collections.Generic;

namespace EtsyBusinessMetricsAPI.DataAcess
{
    public interface ISaleDataAcess
    {
        List<Sale> GetAllSales();
        decimal GetSumOfSales();
    }
}