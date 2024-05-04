using Microsoft.AspNetCore.Components;
using RSM.EN.DTO.Person.Search;
using RSM.EN.DTO.SalesOrderDetail.Search;
using RSM.WEB.Services.Interface;

namespace RSM.WEB.Pages.SalesOrderDetail
{
    public partial class SalesOrderDetail
    {
        [Inject]
        private ISalesOrderDetailService _salesOrderDetailService { get; set; }

        List<SearchSalesOrderDetailResponse> salesOrderDetail = new List<SearchSalesOrderDetailResponse>();

        protected async override Task OnInitializedAsync()
        {
            await GetSalesOrderDetailInformation();
        }

        protected async Task GetSalesOrderDetailInformation()
        {
            var response = await _salesOrderDetailService.GetSalesOrderDetailInformation();
            if (response.Count > 0)
            {
                salesOrderDetail = response;
            }
        }
    }
}
