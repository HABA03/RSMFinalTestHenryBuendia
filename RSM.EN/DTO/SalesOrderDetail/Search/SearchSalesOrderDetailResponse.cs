﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.EN.DTO.SalesOrderDetail.Search
{
	public class SearchSalesOrderDetailResponse
	{
		public int SalesOrderDetailID { get; set; }
		public string? CarrierTrackingNumber { get; set; }
		public short OrderQty { get; set; }
		public decimal UnitPrice { get; set; }
		public decimal UnitPriceDiscount { get; set; }
		public decimal LineTotal { get; set; }
		public Guid rowguid { get; set; }
		public DateTime ModifiedDate { get; set; }
		public int ProductID { get; set; }
		public int SalesOrderID { get; set; }
	}
}
