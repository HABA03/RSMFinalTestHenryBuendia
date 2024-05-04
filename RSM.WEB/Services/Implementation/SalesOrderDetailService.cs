using RSM.EN.DTO.Product.Search;
using RSM.EN.DTO.SalesOrderDetail.Search;
using RSM.EN.Routes;
using RSM.WEB.Services.Interface;
using System.Net.Http.Json;

namespace RSM.WEB.Services.Implementation
{
    public class SalesOrderDetailService : ISalesOrderDetailService
    {
        private readonly HttpClient _httpClient;
        string apiLocalHost = "https://localhost:7141";

        public SalesOrderDetailService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<List<SearchSalesOrderDetailResponse>> GetSalesOrderDetailInformation()
        {
            string api = apiLocalHost + Routes.SalesOrderDetail.GetAllInformationSalesOrderDetail;
            var result = await _httpClient.GetFromJsonAsync<List<SearchSalesOrderDetailResponse>>(api);
            return result ?? new List<SearchSalesOrderDetailResponse>();
        }
    }
}
