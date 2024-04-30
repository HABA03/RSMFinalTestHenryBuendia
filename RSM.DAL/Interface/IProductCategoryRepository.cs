using RSM.DAL.Models;

namespace RSM.DAL.Interface
{
	public interface IProductCategoryRepository
	{
		Task<List<ProductCategory>> GetAllInformation();
	}
}
