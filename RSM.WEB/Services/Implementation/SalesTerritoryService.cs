using RSM.EN.DTO.Product.Search;
using RSM.EN.DTO.SalesTerritory.Search;
using RSM.EN.Routes;
using RSM.WEB.Services.Interface;
using System.Net.Http.Json;

namespace RSM.WEB.Services.Implementation
{
    public class SalesTerritoryService : ISalesTerritoryService
    {
        private readonly HttpClient _httpClient;
        string apiLocalHost = "https://localhost:7141";

        public SalesTerritoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<SearchSalesTerritoryResponse>> GetSalesTerritoryInformation()
        {
            string api = apiLocalHost + Routes.SalesTerritory.GetAllInformationSalesTerritory;
            var result = await _httpClient.GetFromJsonAsync<List<SearchSalesTerritoryResponse>>(api);
            return result ?? new List<SearchSalesTerritoryResponse>();
        }
    }
}
