using Microsoft.AspNetCore.Components;
using RSM.EN.DTO.Helper.Filter;
using RSM.EN.DTO.PdfSalesReport1Information.CreatePdf;
using RSM.EN.DTO.PdfSalesReport2Information.CreatePdfInformation;
using RSM.EN.DTO.SalesOrderHeader.GetSalesReport;
using RSM.WEB.Services.Interface;

namespace RSM.WEB.Pages.SalesReport2
{
	public partial class SalesReport2
	{
        [Inject]
        private ISalesOrderHeaderService _salesOrderHeaderService { get; set; }

        List<GetTheSalesReportResponse> getSalesReportResponse = new List<GetTheSalesReportResponse>();
        List<CreatePdfInformationRequest> pdfInformation = new List<CreatePdfInformationRequest>();
        FilterInformationRequest filterBy = new FilterInformationRequest();
        public string Tittle = "You need to generate a sales report";

        protected async override Task OnInitializedAsync()
        {
            filterBy.Value = "0";
            filterBy.FilterID = 0;
        }

        protected async Task GetAllTheInformationOfSalesReport()
        {
            getSalesReportResponse = new List<GetTheSalesReportResponse>();
            pdfInformation = new List<CreatePdfInformationRequest>();
            var response = await _salesOrderHeaderService.GetSecondSalesReport(filterBy);
            Tittle = "Loading...";
            foreach (var responseItem in response)
            {
                var informationForPdf = new CreatePdfInformationRequest
                {
                    OrderID = responseItem.OrderID,
                    OrderDate = responseItem.OrderDate,
                    CustomerID = responseItem.CustomerID,
                    ProductID = responseItem.ProductID,
                    ProductName = responseItem.ProductName,
                    ProductCategory = responseItem.ProductCategory,
                    UnitPrice = responseItem.UnitPrice,
                    Quantity = responseItem.Quantity,
                    TotalPrice = responseItem.TotalPrice,
                    SalesPersonID = responseItem.SalesPersonID,
                    SalesPersonName = responseItem.SalesPersonName,
                    ShipToAddressID = responseItem.ShipToAddressID,
                    BillToAddressID = responseItem.BillToAddressID
                };
                pdfInformation.Add(informationForPdf);
            }

            if (response.Count > 0)
            {
                getSalesReportResponse = response;
                Tittle = "Second Sales Report";
            }
            filterBy.Value = "0";
            filterBy.FilterID = 0;
            StateHasChanged();
        }

        private async Task GeneratePdf()
        {
            if (pdfInformation.Count > 0) 
            {
                await _salesOrderHeaderService.GeneratePdf(pdfInformation);           
                Tittle = "Pdf downloaded, generate a new report";
                getSalesReportResponse = new List<GetTheSalesReportResponse>();
            }
        }
    }
}
