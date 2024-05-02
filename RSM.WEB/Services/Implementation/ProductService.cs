using RSM.EN.DTO.Product.Search;
using RSM.EN.Routes;
using RSM.WEB.Services.Interface;
using System.Net.Http.Json;

namespace RSM.WEB.Services.Implementation
{
	public class ProductService : IProductService
	{
		private readonly HttpClient _httpClient;
		string apiLocalHost = "http://localhost:5283";

		public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<SearchProductResponse>> GetAllProducts()
		{
			var response = await _httpClient.GetAsync(apiLocalHost + Routes.Product.GetAllInformationProduct);
			var products = await response.Content.ReadFromJsonAsync<List<SearchProductResponse>>();
			return products;
		}
	}
}
