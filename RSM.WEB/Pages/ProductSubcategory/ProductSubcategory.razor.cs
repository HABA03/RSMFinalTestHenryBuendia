using Microsoft.AspNetCore.Components;
using RSM.EN.DTO.ProductSubcategory.Search;
using RSM.WEB.Services.Interface;

namespace RSM.WEB.Pages.ProductSubcategory
{
    public partial class ProductSubcategory
    {
        [Inject]
        private IProductSubcategoryService _productSubcategoryService { get; set; }

        List<SearchProductSubcategoryResponse> searchProductSubcategoryResponses = new List<SearchProductSubcategoryResponse>();

        protected async override Task OnInitializedAsync()
        {
            await GetProductsSubcategoriesInformation();
        }

        protected async Task GetProductsSubcategoriesInformation()
        {
            var response = await _productSubcategoryService.GetAllProductsSubcategories();
            if (response.Count > 0)
            {
                searchProductSubcategoryResponses = response;
            }
        }
    }
}
