using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.EN.DTO.ProductCategory.Search
{
	public class SearchProductCategoryResponse
	{
		public int ProductCategoryID { get; set; }
		public string Name { get; set; }
		public Guid rowguid { get; set; }
		public DateTime ModifiedDate { get; set; }
	}
}
