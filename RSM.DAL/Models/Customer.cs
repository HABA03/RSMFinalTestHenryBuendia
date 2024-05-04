using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.DAL.Models
{
	public class Customer
	{
        public int CustomerID { get; set; }
		public string AccountNumber { get; set; }
		public Guid rowguid { get; set; }
		public DateTime ModifiedDate { get; set; }

		public int? TerritoryID { get; set; }
		public int? PersonID { get; set; }

		public SalesTerritory SalesTerritory { get; set; }
		public Person Person { get; set; }

		public List<SalesOrderHeader> SalesOrderHeader { get; set; }
	}
}
