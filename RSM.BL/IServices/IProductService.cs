using RSM.EN.DTO.Product.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BL.IServices
{
	public interface IProductService
	{
		Task<List<SearchProductResponse>> GetAllInformationProduct();
	}
}
