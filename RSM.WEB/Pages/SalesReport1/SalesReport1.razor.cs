using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using RSM.EN.DTO.Helper.Filter;
using RSM.EN.DTO.PdfSalesReport1Information.CreatePdf;
using RSM.EN.DTO.Product.GetSalesReport;
using RSM.WEB.Services.Interface;
using System.ComponentModel;


namespace RSM.WEB.Pages.SalesReport1
{
    public partial class SalesReport1
    {
        [Inject]
        private IProductService _productService { get; set; }

        List<GetSalesReportResponse> getSalesReportResponse = new List<GetSalesReportResponse>();
        List<CreatePdfRequest> pdfInformation = new List<CreatePdfRequest>();
        FilterInformationRequest filterBy = new FilterInformationRequest();
        public string Tittle = "You need to generate a sales report";
        private ElementReference pdfContainer;

        protected async override Task OnInitializedAsync()
        {
            filterBy.Value = "0";
            filterBy.FilterID = 0;
        }

        protected async Task GetAllTheInformationOfSalesReport()
        {
            getSalesReportResponse = new List<GetSalesReportResponse>();
            pdfInformation = new List<CreatePdfRequest>();
            var response = await _productService.GetFirstSalesReport(filterBy);
            Tittle = "Loading...";
            foreach (var responseItem in response) 
            {
                var informationForPdf = new CreatePdfRequest
                {
                    ProductID = responseItem.ProductID,
                    ProductName = responseItem.ProductName,
                    CategoryName = responseItem.CategoryName,
                    TotalSales = responseItem.TotalSales,
                    Region = responseItem.Region,
                    PercentageOfTotalCategorySalesInRegion = responseItem.PercentageOfTotalCategorySalesInRegion,
                    PercentageOfTotalSalesInRegion = responseItem.PercentageOfTotalSalesInRegion
                };

                pdfInformation.Add(informationForPdf);
            }

            if (response.Count > 0)
            {
                getSalesReportResponse = response;
                Tittle = "First Sales Report";
            }
            filterBy.Value = "0";
            filterBy.FilterID = 0;
            StateHasChanged();
        }

        private async Task GeneratePdf()
        {
            if (pdfInformation.Count > 0)
            {
                await _productService.GeneratePdf(pdfInformation);          
                Tittle = "Pdf downloaded, generate a new report";
                getSalesReportResponse = new List<GetSalesReportResponse>();
            }
        }
    }
}