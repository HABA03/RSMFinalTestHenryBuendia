using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.EN.DTO.SalesTerritory.Search
{
	public class SearchSalesTerritoryResponse
	{
		public int TerritoryID { get; set; }
		public string Name { get; set; }
		public string CountryRegionCode { get; set; }
		public string Group { get; set; }
		public decimal SalesYTD { get; set; }
		public decimal SalesLastYear { get; set; }
		public decimal CostYTD { get; set; }
		public Guid rowguid { get; set; }
		public DateTime ModifiedDate { get; set; }
	}
}
