using RSM.EN.DTO.ProductSubcategory.Search;

namespace RSM.WEB.Services.Interface
{
    public interface IProductSubcategoryService
    {
        Task<List<SearchProductSubcategoryResponse>> GetAllProductsSubcategories();
    }
}
