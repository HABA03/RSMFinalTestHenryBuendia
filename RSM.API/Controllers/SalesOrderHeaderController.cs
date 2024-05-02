using Microsoft.AspNetCore.Mvc;
using RSM.BL.IServices;
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

        public SalesOrderHeaderController(ISalesOrderHeaderService salesOrderHeaderService)
        {
            _salesOrderHeaderService = salesOrderHeaderService;
        }

		[HttpGet(Routes.SalesOrderHeader.GetAllInformationSalesOrderHeader)]
		[ProducesResponseType(typeof(List<SearchSalesOrderHeeaderResponse>), StatusCodes.Status200OK)]
		public async Task<IActionResult> GetAll()
		{
			var result = await _salesOrderHeaderService.GetAllInformationSalesOrderHeader();
			return Ok(result);
		}

		[HttpGet(Routes.SalesOrderHeader.GetSalesReport)]
		[ProducesResponseType(typeof(List<GetTheSalesReportResponse>), StatusCodes.Status200OK)]
		public async Task<IActionResult> GetSalesReportInformation()
		{
			var result = await _salesOrderHeaderService.GetTheSalesReport();
			return Ok(result);
		}
	}
}
