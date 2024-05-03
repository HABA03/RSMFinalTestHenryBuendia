using RSM.EN.DTO.ProductCategory.Search;
using RSM.EN.DTO.ProductSubcategory.Search;
using RSM.EN.Routes;
using RSM.WEB.Services.Interface;
using System.Net.Http.Json;

namespace RSM.WEB.Services.Implementation
{
    public class ProductSubcategoryService : IProductSubcategoryService
    {
        private readonly HttpClient _httpClient;
        string apiLocalHost = "https://localhost:7141";

        public ProductSubcategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<SearchProductSubcategoryResponse>> GetAllProductsSubcategories()
        {
            string api = apiLocalHost + Routes.ProductSubcategory.GetAllInformationProductSubCategory;
            var result = await _httpClient.GetFromJsonAsync<List<SearchProductSubcategoryResponse>>(api);
            return result ?? new List<SearchProductSubcategoryResponse>();
        }
    }
}
