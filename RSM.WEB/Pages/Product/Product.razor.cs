using Microsoft.AspNetCore.Components;
using RSM.EN.DTO.Product.Search;
using RSM.EN.DTO.SalesOrderDetail.Search;
using RSM.EN.DTO.SalesOrderHeader.Search;
using RSM.WEB.Services.Interface;

namespace RSM.WEB.Pages.Product
{
    public partial class Product
    {
        [Inject]
        private IProductService _productService { get; set; }

        List<SearchProductResponse> productService = new List<SearchProductResponse>();

        protected async override Task OnInitializedAsync()
        {
            await GetProductInformation();
        }

        protected async Task GetProductInformation()
        {
            var response = await _productService.GetAllProductsInformation();
            if (response.Count > 0)
            {
                productService = response;
            }
        }
    }
}
