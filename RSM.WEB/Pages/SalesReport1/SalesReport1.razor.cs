using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using RSM.EN.DTO.Helper.Filter;
using RSM.EN.DTO.Product.GetSalesReport;
using RSM.WEB.Services.Interface;
using Syncfusion.Drawing;
using Syncfusion.HtmlConverter;
using Syncfusion.Pdf;
using Syncfusion.Pdf.Graphics;
using System.ComponentModel;


namespace RSM.WEB.Pages.SalesReport1
{
    public partial class SalesReport1
    {
        [Inject]
        private IProductService _productService { get; set; }

        List<GetSalesReportResponse> getSalesReportResponse = new List<GetSalesReportResponse>();
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
            var response = await _productService.GetFirstSalesReport(filterBy);
            if (response.Count > 0)
            {
                getSalesReportResponse = response;
                Tittle = "First Sales Report";
            }
            StateHasChanged();
        }

        private async Task GeneratePdf()
        {
        }
    }
}