using RSM.EN.DTO.ProductCategory.Search;

namespace RSM.WEB.Services.Interface
{
	public interface IProductCategoryService
	{
		Task<List<SearchProductCategoryResponse>> GetAllProductsCategories();
	}
}
