using RSM.EN.DTO.SalesTerritory.Search;

namespace RSM.WEB.Services.Interface
{
    public interface ISalesTerritoryService
    {
        Task<List<SearchSalesTerritoryResponse>> GetSalesTerritoryInformation();
    }
}
