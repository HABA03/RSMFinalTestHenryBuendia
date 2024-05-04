using Microsoft.AspNetCore.Mvc;
using RSM.BL.IServices;
using RSM.BL.Services;
using RSM.EN.DTO.Customer.Search;
using RSM.EN.DTO.ProductCategory.Search;
using RSM.EN.Routes;

namespace RSM.API.Controllers
{
	[Route(Routes.Customer.Controller)]
	[ApiController]
	public class CustomerController : ControllerBase
	{
		private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

		[HttpGet(Routes.Customer.GetAllInformationCustomers)]
		[ProducesResponseType(typeof(List<SearchCustomerResponse>), StatusCodes.Status200OK)]
		public async Task<IActionResult> GetAll()
		{
			var result = await _customerService.GetAllInformationCustomer();
			return Ok(result);
		}
    }
}
