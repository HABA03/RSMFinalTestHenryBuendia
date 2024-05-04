using Microsoft.AspNetCore.Mvc;
using RSM.BL.IServices;
using RSM.BL.Services;
using RSM.EN.DTO.SalesOrderHeader.Search;
using RSM.EN.DTO.SalesTerritory.Search;
using RSM.EN.Routes;

namespace RSM.API.Controllers
{
	[Route(Routes.SalesTerritory.Controller)]
	[ApiController]
	public class SalesTerritoryController : ControllerBase
	{

		private readonly ISalesTerritoryService _salesTerritoryService;

		public SalesTerritoryController(ISalesTerritoryService salesTerritoryService)
		{
			_salesTerritoryService = salesTerritoryService;
		}

		[HttpGet(Routes.SalesTerritory.GetAllInformationSalesTerritory)]
		[ProducesResponseType(typeof(List<SearchSalesTerritoryResponse>), StatusCodes.Status200OK)]
		public async Task<IActionResult> GetAll()
		{
			var result = await _salesTerritoryService.GetAllInformationSalesTerritory();
			return Ok(result);
		}
	}
}
