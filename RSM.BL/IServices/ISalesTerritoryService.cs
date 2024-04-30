using RSM.EN.DTO.SalesTerritory.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BL.IServices
{
	public interface ISalesTerritoryService
	{
		Task<List<SearchSalesTerritoryResponse>> GetAllInformationSalesTerritory();
	}
}
