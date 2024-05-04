using RSM.EN.DTO.Customer.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BL.IServices
{
	public interface ICustomerService
	{
		Task<List<SearchCustomerResponse>> GetAllInformationCustomer();
	}
}
