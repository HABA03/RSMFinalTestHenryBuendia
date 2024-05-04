using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.EN.DTO.Customer.Search
{
	public class SearchCustomerResponse
	{
		public int CustomerID { get; set; }
		public string AccountNumber { get; set; }
		public Guid rowguid { get; set; }
		public DateTime ModifiedDate { get; set; }

		public int? TerritoryID { get; set; }
		public int? PersonID { get; set; }
	}
}
