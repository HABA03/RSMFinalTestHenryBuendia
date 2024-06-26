﻿using RSM.EN.DTO.ProductCategory.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.EN.DTO.ProductSubcategory.Search
{
	public class SearchProductSubcategoryResponse
	{
		public int ProductSubcategoryID { get; set; }
		public string Name { get; set; }
		public Guid rowguid { get; set; }
		public DateTime ModifiedDate { get; set; }

		//Foreign key
		public int ProductCategoryID { get; set; }
		public SearchProductCategoryResponse SearchProductCategoryResponse { get; set; }
	}
}
