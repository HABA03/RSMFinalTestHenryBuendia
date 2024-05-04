using Microsoft.AspNetCore.Mvc;
using RSM.BL.IServices;
using RSM.BL.Services;
using RSM.EN.DTO.ProductCategory.Search;
using RSM.EN.DTO.SalesOrderDetail.Search;
using RSM.EN.Routes;

namespace RSM.API.Controllers
{
	[Route(Routes.SalesOrderDetail.Controller)]
	[ApiController]
	public class SalesOrderDetailController : ControllerBase
	{
		private readonly ISalesOrderDetailService _salesOrderDetailService;

        public SalesOrderDetailController(ISalesOrderDetailService salesOrderDetailService)
        {
            _salesOrderDetailService = salesOrderDetailService;
        }

		[HttpGet(Routes.SalesOrderDetail.GetAllInformationSalesOrderDetail)]
		[ProducesResponseType(typeof(List<SearchSalesOrderDetailResponse>), StatusCodes.Status200OK)]
		public async Task<IActionResult> GetAll()
		{
			var result = await _salesOrderDetailService.GetAllInformationSalesOrderDetail();
			return Ok(result);
		}
	}
}
