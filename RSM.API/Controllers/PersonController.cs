using Microsoft.AspNetCore.Mvc;
using RSM.BL.IServices;
using RSM.BL.Services;
using RSM.EN.DTO.Customer.Search;
using RSM.EN.DTO.Person.Search;
using RSM.EN.Routes;

namespace RSM.API.Controllers
{
	[Route(Routes.Person.Controller)]
	[ApiController]
	public class PersonController : ControllerBase
	{
		private readonly IPersonService _personService;

        public PersonController(IPersonService personService)
        {
            _personService = personService;
        }

		[HttpGet(Routes.Person.GetAllInformationPerson)]
		[ProducesResponseType(typeof(List<SearchPersonResponse>), StatusCodes.Status200OK)]
		public async Task<IActionResult> GetAll()
		{
			var result = await _personService.GetAllInformationPerson();
			return Ok(result);
		}
	}
}
