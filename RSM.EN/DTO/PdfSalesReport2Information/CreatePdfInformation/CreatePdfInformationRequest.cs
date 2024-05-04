using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.EN.DTO.PdfSalesReport2Information.CreatePdfInformation
{
    public class CreatePdfInformationRequest
    {
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public int CustomerID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string ProductCategory { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public int? SalesPersonID { get; set; }
        public string SalesPersonName { get; set; }
        public int ShipToAddressID { get; set; }
        public int BillToAddressID { get; set; }
    }
}
