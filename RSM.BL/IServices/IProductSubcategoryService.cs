using RSM.EN.DTO.ProductSubcategory.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BL.IServices
{
	public interface IProductSubcategoryService
	{
		Task<List<SearchProductSubcategoryResponse>> GetAllInformationProductSubcategory();
	}
}
