using RSM.EN.DTO.Helper.Filter;
using RSM.EN.DTO.SalesOrderHeader.GetSalesReport;
using RSM.EN.DTO.SalesOrderHeader.Search;

namespace RSM.WEB.Services.Interface
{
    public interface ISalesOrderHeaderService
    {
        Task<List<SearchSalesOrderHeeaderResponse>> GetAllInformationSalesOrderHeader();
        Task<List<GetTheSalesReportResponse>> GetSecondSalesReport(FilterInformationRequest request);
    }
}
