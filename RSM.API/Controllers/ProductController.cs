using Microsoft.AspNetCore.Mvc;
using RSM.BL.IServices;
using RSM.BL.Services;
using RSM.EN.DTO.Helper.Filter;
using RSM.EN.DTO.PdfSalesReport1Information.CreatePdf;
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
		private readonly IPdfGenerator _pdfGenerator;

        public ProductController(IProductService productService, IPdfGenerator pdfGenerator)
        {
            _productService = productService;
			_pdfGenerator = pdfGenerator;
        }

		[HttpGet(Routes.Product.GetAllInformationProduct)]
		[ProducesResponseType(typeof(List<SearchProductResponse>), StatusCodes.Status200OK)]
		public async Task<IActionResult> GetAll()
		{
			var result = await _productService.GetAllInformationProduct();
			return Ok(result);
		}

		[HttpPost(Routes.Product.GetSalesReport)]
		[ProducesResponseType(typeof(List<GetSalesReportResponse>), StatusCodes.Status200OK)]
		public async Task<IActionResult> GetSalesReport([FromBody] FilterInformationRequest request)
		{
			var result = await _productService.GetSalesReport(request);
			return Ok(result);
		}

        [HttpPost(Routes.Product.GeneratePdf)]
        [ProducesResponseType(typeof(CreatePdfResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> GeneratePdf([FromBody] List<CreatePdfRequest> request)
        {
            var result = await _pdfGenerator.CreatePdf1(request);
            return Ok(result);
        }
    }
}
