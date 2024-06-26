﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.DAL.Models
{
	public class ProductCategory
	{
		public int ProductCategoryID { get; set; }
		public string Name { get; set; }
		public Guid rowguid { get; set; }
		public DateTime ModifiedDate { get; set; }

		public List<ProductSubcategory> ProductSubcategories { get; set; }
	}
}
