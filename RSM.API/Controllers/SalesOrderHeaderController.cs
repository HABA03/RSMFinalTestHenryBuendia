using Microsoft.AspNetCore.Mvc;
using RSM.BL.IServices;
using RSM.EN.DTO.Helper.Filter;
using RSM.EN.DTO.PdfSalesReport2Information.CreatePdfInformation;
using RSM.EN.DTO.SalesOrderHeader.GetSalesReport;
using RSM.EN.DTO.SalesOrderHeader.Search;
using RSM.EN.Routes;
using System.Net;

namespace RSM.API.Controllers
{
	[Route(Routes.SalesOrderHeader.Controller)]
	[ApiController]
	public class SalesOrderHeaderController : ControllerBase
	{
		private readonly ISalesOrderHeaderService _salesOrderHeaderService;
		private readonly IPdfGenerator _pdfGenerator;

        public SalesOrderHeaderController(ISalesOrderHeaderService salesOrderHeaderService, IPdfGenerator pdfGenerator)
        {
            _salesOrderHeaderService = salesOrderHeaderService;
			_pdfGenerator = pdfGenerator;
        }

		[HttpGet(Routes.SalesOrderHeader.GetAllInformationSalesOrderHeader)]
		[ProducesResponseType(typeof(List<SearchSalesOrderHeeaderResponse>), StatusCodes.Status200OK)]
		public async Task<IActionResult> GetAll()
		{
			var result = await _salesOrderHeaderService.GetAllInformationSalesOrderHeader();
			return Ok(result);
		}

		[HttpPost(Routes.SalesOrderHeader.GetSalesReport)]
		[ProducesResponseType(typeof(List<GetTheSalesReportResponse>), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetSalesReportInformation([FromBody] FilterInformationRequest request)
		{
			var result = await _salesOrderHeaderService.GetTheSalesReport(request);
			return Ok(result);
		}

        [HttpPost(Routes.SalesOrderHeader.GeneratePdf)]
        [ProducesResponseType(typeof(CreatePdfInformationResponse), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetSalesReportInformation([FromBody] List<CreatePdfInformationRequest> request)
        {
            var result = await _pdfGenerator.CreatePdf2(request);
            return Ok(result);
        }
    }
}
