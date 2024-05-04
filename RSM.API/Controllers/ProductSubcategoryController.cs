using Microsoft.AspNetCore.Mvc;
using RSM.BL.IServices;
using RSM.BL.Services;
using RSM.EN.DTO.ProductCategory.Search;
using RSM.EN.DTO.ProductSubcategory.Search;
using RSM.EN.Routes;

namespace RSM.API.Controllers
{
	[Route(Routes.ProductSubcategory.Controller)]
	[ApiController]
	public class ProductSubcategoryController : ControllerBase
	{
		private readonly IProductSubcategoryService _productSubcategoryService;

        public ProductSubcategoryController(IProductSubcategoryService productSubcategoryService)
        {
            _productSubcategoryService = productSubcategoryService;
        }

		[HttpGet(Routes.ProductSubcategory.GetAllInformationProductSubCategory)]
		[ProducesResponseType(typeof(List<SearchProductSubcategoryResponse>), StatusCodes.Status200OK)]
		public async Task<IActionResult> GetAll()
		{
			var result = await _productSubcategoryService.GetAllInformationProductSubcategory();
			return Ok(result);
		}
	}
}
