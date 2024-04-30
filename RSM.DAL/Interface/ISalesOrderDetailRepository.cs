using RSM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.DAL.Interface
{
	public interface ISalesOrderDetailRepository
	{
		Task<List<SalesOrderDetail>> GetAllInformation();
	}
}
