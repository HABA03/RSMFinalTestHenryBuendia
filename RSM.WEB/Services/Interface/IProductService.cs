using RSM.EN.DTO.Product.Search;

namespace RSM.WEB.Services.Interface
{
	public interface IProductService
	{
		Task<List<SearchProductResponse>> GetAllProducts();
	}
}
