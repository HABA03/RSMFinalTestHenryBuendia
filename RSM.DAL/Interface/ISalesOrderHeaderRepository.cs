using RSM.DAL.Models;

namespace RSM.DAL.Interface
{
	public interface ISalesOrderHeaderRepository
	{
		Task<List<SalesOrderHeader>> GetAllInformation();
	}
}
