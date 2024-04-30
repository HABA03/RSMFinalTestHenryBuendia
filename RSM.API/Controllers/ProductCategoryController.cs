using Microsoft.AspNetCore.Mvc;
using RSM.BL.IServices;
using RSM.BL.Services;
using RSM.EN.DTO.ProductCategory.Search;
using RSM.EN.Routes;

namespace RSM.API.Controllers
{
	[Route(Routes.ProductCategory.Controller)]
	[ApiController]
	public class ProductCategoryController : ControllerBase
	{
		private readonly IProductCategoryService _productCategoryService;

        public ProductCategoryController(IProductCategoryService productCategoryService)
        {
            _productCategoryService = productCategoryService;	
        }

		[HttpGet(Routes.ProductCategory.GetAllInformationProductCategory)]
		[ProducesResponseType(typeof(List<SearchProductCategoryResponse>), StatusCodes.Status200OK)]
		public async Task<IActionResult> GetAll()
		{
			var result = await _productCategoryService.GetAllInformationProductCategory();
			return Ok(result);
		}
	}
}
