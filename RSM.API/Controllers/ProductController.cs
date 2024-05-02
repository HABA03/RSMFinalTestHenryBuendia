using Microsoft.AspNetCore.Mvc;
using RSM.BL.IServices;
using RSM.BL.Services;
using RSM.EN.DTO.Product.GetSalesReport;
using RSM.EN.DTO.Product.Search;
using RSM.EN.DTO.ProductCategory.Search;
using RSM.EN.Routes;

namespace RSM.API.Controllers
{
	[Route(Routes.Product.Controller)]
	[ApiController]
	public class ProductController : ControllerBase
	{
		private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

		[HttpGet(Routes.Product.GetAllInformationProduct)]
		[ProducesResponseType(typeof(List<SearchProductResponse>), StatusCodes.Status200OK)]
		public async Task<IActionResult> GetAll()
		{
			var result = await _productService.GetAllInformationProduct();
			return Ok(result);
		}

		[HttpGet(Routes.Product.GetSalesReport)]
		[ProducesResponseType(typeof(List<GetSalesReportResponse>), StatusCodes.Status200OK)]
		public async Task<IActionResult> GetSalesReport()
		{
			var result = await _productService.GetSalesReport();
			return Ok(result);
		}
	}
}
