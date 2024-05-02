using RSM.EN.DTO.Product.Search;
using RSM.EN.DTO.ProductCategory.Search;
using RSM.EN.Routes;
using RSM.WEB.Services.Interface;
using System.Net.Http.Json;

namespace RSM.WEB.Services.Implementation
{
	public class ProductCategoryService : IProductCategoryService
	{
		private readonly HttpClient _httpClient;
		string apiLocalHost = "http://localhost:5283";

		public ProductCategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

		public async Task<List<SearchProductCategoryResponse>> GetAllProductsCategories()
		{
			var result = await _httpClient.GetFromJsonAsync<List<SearchProductCategoryResponse>>(apiLocalHost + Routes.ProductCategory.GetAllInformationProductCategory);
			return result;
		}
	}
}
