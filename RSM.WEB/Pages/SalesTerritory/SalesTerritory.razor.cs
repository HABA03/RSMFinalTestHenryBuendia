using Microsoft.AspNetCore.Components;
using RSM.EN.DTO.SalesTerritory.Search;
using RSM.WEB.Services.Interface;

namespace RSM.WEB.Pages.SalesTerritory
{
    public partial class SalesTerritory
    {
        [Inject]
        private ISalesTerritoryService _salesTerritoryService { get; set; }

        List<SearchSalesTerritoryResponse> salesTerritory = new List<SearchSalesTerritoryResponse>();

        protected async override Task OnInitializedAsync()
        {
            await GetSalesTerritoryInformation();
        }

        protected async Task GetSalesTerritoryInformation()
        {
            var response = await _salesTerritoryService.GetSalesTerritoryInformation();
            if (response.Count > 0)
            {
                salesTerritory = response;
            }
        }
    }
}
