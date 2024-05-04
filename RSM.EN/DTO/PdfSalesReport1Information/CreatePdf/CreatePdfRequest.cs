using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.EN.DTO.PdfSalesReport1Information.CreatePdf
{
    public class CreatePdfRequest
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public string CategoryName { get; set; }
        public decimal TotalSales { get; set; }
        public string Region { get; set; }
        public decimal PercentageOfTotalSalesInRegion { get; set; }
        public decimal PercentageOfTotalCategorySalesInRegion { get; set; }
    }
}
