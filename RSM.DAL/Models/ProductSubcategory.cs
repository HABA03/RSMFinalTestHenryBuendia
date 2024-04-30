using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.DAL.Models
{
	public class ProductSubcategory
	{
		public int ProductSubcategoryID { get; set; }
		public string Name { get; set; }
		public Guid rowguid { get; set; }
		public DateTime ModifiedDate { get; set; }

		//Foreign key
		public int ProductCategoryID { get; set; }
	}
}
