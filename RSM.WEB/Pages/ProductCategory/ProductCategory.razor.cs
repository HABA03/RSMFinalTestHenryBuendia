using Microsoft.AspNetCore.Components;
using RSM.EN.DTO.ProductCategory.Search;
using RSM.WEB.Services.Interface;

namespace RSM.WEB.Pages.ProductCategory
{
    public partial class ProductCategory
    {
        [Inject]
        private IProductCategoryService _productCategoryService {  get; set; }

        List<SearchProductCategoryResponse> searchProductCategoryResponses = new List<SearchProductCategoryResponse>();

        protected async override Task OnInitializedAsync()
        {
            await GetProductsCategoriesInformation();
        }

        protected async Task GetProductsCategoriesInformation() 
        {
            var response = await _productCategoryService.GetAllProductsCategories();
            if (response.Count > 0) 
            {
                searchProductCategoryResponses = response;
            }
        }
    }
}
