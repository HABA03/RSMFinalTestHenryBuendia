using Microsoft.AspNetCore.Components;
using RSM.EN.DTO.Helper.Filter;
using RSM.EN.DTO.SalesOrderHeader.GetSalesReport;
using RSM.WEB.Services.Interface;

namespace RSM.WEB.Pages.SalesReport2
{
	public partial class SalesReport2
	{
        [Inject]
        private ISalesOrderHeaderService _salesOrderHeaderService { get; set; }

        List<GetTheSalesReportResponse> getSalesReportResponse = new List<GetTheSalesReportResponse>();
        FilterInformationRequest filterBy = new FilterInformationRequest();
        public string Tittle = "You need to generate a sales report";

        protected async override Task OnInitializedAsync()
        {
            filterBy.Value = "0";
            filterBy.FilterID = 0;
        }

        protected async Task GetAllTheInformationOfSalesReport()
        {
            var response = await _salesOrderHeaderService.GetSecondSalesReport(filterBy);
            if (response.Count > 0)
            {
                getSalesReportResponse = response;
                Tittle = "Second Sales Report";
            }
            StateHasChanged();
        }
    }
}
