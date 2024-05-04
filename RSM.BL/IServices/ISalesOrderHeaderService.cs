using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSM.EN.DTO;
using RSM.EN.DTO.Helper.Filter;
using RSM.EN.DTO.SalesOrderHeader.GetSalesReport;
using RSM.EN.DTO.SalesOrderHeader.Search;

namespace RSM.BL.IServices
{
	public interface ISalesOrderHeaderService
	{
		Task<List<SearchSalesOrderHeeaderResponse>> GetAllInformationSalesOrderHeader();
		Task<List<GetTheSalesReportResponse>> GetTheSalesReport(FilterInformationRequest request);
	}
}
