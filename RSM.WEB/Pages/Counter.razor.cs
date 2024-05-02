using Microsoft.AspNetCore.Components;
using RSM.EN.DTO.Product.Search;
using RSM.WEB.Services.Interface;

namespace RSM.WEB.Pages
{
	public partial class Counter
	{
		[Inject]
		private IProductService _productService { get; set; }

		[Inject]
		private IProductCategoryService ProductCategory { get; set; }
		public List<SearchProductResponse> _products { get; set; }

		protected async override Task OnInitializedAsync()
		{
			await GetProductsInformation();
		}

		protected async Task GetProductsInformation()
		{
			var prueba = await ProductCategory.GetAllProductsCategories();
			var listOfProducts = await _productService.GetAllProducts();
			
			if (listOfProducts != null) 
			{
				var listResponse = listOfProducts;
			}
		}
	}
}
