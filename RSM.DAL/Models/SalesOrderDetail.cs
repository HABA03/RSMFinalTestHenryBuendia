using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.DAL.Models
{
	public class SalesOrderDetail
	{
		public int SalesOrderDetailID { get; set; }
		public int? CarrierTrackingNumber { get; set; }
		public short OrderQty { get; set; }
		public decimal UnitPrice { get; set; }
		public decimal UnitPriceDiscount { get; set; }
		public decimal LineTotal { get; set; }
		public Guid rowguid { get; set; }
		public DateTime ModifiedDate { get; set; }

		//Foreign keys
		public int ProductID { get; set; }
		public int SalesOrderID { get; set; }
	}
}
