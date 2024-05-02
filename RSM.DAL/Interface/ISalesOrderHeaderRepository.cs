using RSM.DAL.Models;
using RSM.EN.DTO.SalesOrderHeader.GetSalesReport;

namespace RSM.DAL.Interface
{
	public interface ISalesOrderHeaderRepository
	{
		Task<List<SalesOrderHeader>> GetAllInformation();
		Task<List<GetTheSalesReportResponse>> GetTheSalesReport();
	}
}
