using RSM.EN.DTO.Person.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BL.IServices
{
	public interface IPersonService
	{
		Task<List<SearchPersonResponse>> GetAllInformationPerson();
	}
}
