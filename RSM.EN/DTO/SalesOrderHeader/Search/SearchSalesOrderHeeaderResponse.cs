﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 

namespace RSM.EN.DTO.SalesOrderHeader.Search
{
	public class SearchSalesOrderHeeaderResponse
	{
		public int SalesOrderID { get; set; }
		public byte RevisionNumber { get; set; }
		public DateTime OrderDate { get; set; }
		public DateTime DueDate { get; set; }
		public DateTime? ShipDate { get; set; }
		public byte Status { get; set; }
		public bool OnlineOrderFlag { get; set; }
		public string SalesOrderNumber { get; set; }
		public string? PurchaseOrderNumber { get; set; }
		public string? AccountNumber { get; set; }
		public string? CreditCardApprovalCode { get; set; }
		public decimal SubTotal { get; set; }
		public decimal TaxAmt { get; set; }
		public decimal Freight { get; set; }
		public decimal TotalDue { get; set; }
		public string? Comment { get; set; }
		public Guid rowguid { get; set; }
		public DateTime ModifiedDate { get; set; }
		public int ShipToAddressID { get; set; }
		public int BillToAddressID { get; set; }

		//Foreign keys
		public int? TerritoryID { get; set; }
        public int CustomerID { get; set; }
    }
}
