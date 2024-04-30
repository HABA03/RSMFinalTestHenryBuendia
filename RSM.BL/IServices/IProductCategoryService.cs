using RSM.EN.DTO.ProductCategory.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BL.IServices
{
	public interface IProductCategoryService
	{
		Task<List<SearchProductCategoryResponse>> GetAllInformationProductCategory();
	}
}
