using RSM.EN.DTO.SalesOrderDetail.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BL.IServices
{
	public interface ISalesOrderDetailService
	{
		Task<List<SearchSalesOrderDetailResponse>> GetAllInformationSalesOrderDetail();
	}
}
