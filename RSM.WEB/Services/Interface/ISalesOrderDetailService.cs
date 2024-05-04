using RSM.EN.DTO.SalesOrderDetail.Search;

namespace RSM.WEB.Services.Interface
{
    public interface ISalesOrderDetailService
    {
        Task<List<SearchSalesOrderDetailResponse>> GetSalesOrderDetailInformation();
    }
}
