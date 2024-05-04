using Microsoft.AspNetCore.Components;
using RSM.EN.DTO.SalesOrderHeader.Search;
using RSM.WEB.Services.Interface;

namespace RSM.WEB.Pages.SalesOrderHeader
{
    public partial class SalesOrderHeader
    {
        [Inject]
        private ISalesOrderHeaderService _salesOrderHeaderService { get; set; }

        List<SearchSalesOrderHeeaderResponse> salesOrderHeader = new List<SearchSalesOrderHeeaderResponse>();

        protected async override Task OnInitializedAsync()
        {
            await GetSalesOrderHeaderInformation();
        }

        protected async Task GetSalesOrderHeaderInformation()
        {
            var response = await _salesOrderHeaderService.GetAllInformationSalesOrderHeader();
            if (response.Count > 0)
            {
                salesOrderHeader = response;
            }
        }
    }
}
