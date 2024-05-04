using RSM.EN.DTO.ProductCategory.Search;
using RSM.EN.Routes;
using RSM.WEB.Services.Interface;
using System.Net.Http.Json;
using Microsoft.Extensions.Http;

namespace RSM.WEB.Services.Implementation
{
	public class ProductCategoryService : IProductCategoryService
	{
		private readonly HttpClient _httpClient;
		string apiLocalHost = "https://localhost:7141";

		public ProductCategoryService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		public async Task<List<SearchProductCategoryResponse>> GetAllProductsCategories()
		{
			string api = apiLocalHost + Routes.ProductCategory.GetAllInformationProductCategory;
			var result = await _httpClient.GetFromJsonAsync<List<SearchProductCategoryResponse>>(api);
			return result ?? new List<SearchProductCategoryResponse>();
		}
	}
}
