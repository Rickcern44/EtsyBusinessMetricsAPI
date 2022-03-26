using EtsyBusinessMetricsAPI.Models;
using RestSharp;
using RestSharp.Authenticators;

namespace EtsyBusinessMetricsAPI.Services
{
    public class EtsyApiService
    {
        //public EtsySale GetSalesData()
        //{
        //    string baseUrl = "https://openapi.etsy.com/v2/shops/21594656/";

        //    string consumerKey = "u4zj4e4jcakajf2wtanvtljn";
        //    string consumerSecret = "k51t6ib8jq";
        //    string oAuthToken = "c0cd1745bc4f14b6a268ee88c45fe9";
        //    string oAuthSecret = "420e7bbf0d";


        //   //Reworking this is the most effecient way to call an API that has OAuth with RestSharp 
        //    var etsyRestClient = new RestClient(baseUrl)
        //    {
        //        Authenticator = OAuth1Authenticator.ForProtectedResource(consumerKey, consumerSecret, oAuthToken, oAuthSecret)
        //    };

        //    var request = new RestRequest("transactions", Method.GET);
        //    request.AddParameter("limit", "1000");

        //    IRestResponse<EtsySale> response = etsyRestClient.Execute<EtsySale>(request);

        //    return response.Data;

        //}

        //public EtsyReceipt GetReceipts()
        //{

        //    string baseUrl = "https://openapi.etsy.com/v2/shops/21594656/";

        //    string consumerKey = "u4zj4e4jcakajf2wtanvtljn";
        //    string consumerSecret = "k51t6ib8jq";
        //    string oAuthToken = "c0cd1745bc4f14b6a268ee88c45fe9";
        //    string oAuthSecret = "420e7bbf0d";

        //    var etsyRestClient = new RestClient(baseUrl)
        //    {
        //        Authenticator = OAuth1Authenticator.ForProtectedResource(consumerKey, consumerSecret, oAuthToken, oAuthSecret)
        //    };

        //    var request = new RestRequest("receipts", Method.GET);
        //    request.AddParameter("limit", "1000");

        //    IRestResponse<EtsyReceipt> response = etsyRestClient.Execute<EtsyReceipt>(request);

        //    return response.Data;
        //}

    }
}
