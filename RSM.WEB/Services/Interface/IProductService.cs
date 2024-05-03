using RSM.EN.DTO.Helper.Filter;
using RSM.EN.DTO.Product.GetSalesReport;
using RSM.EN.DTO.Product.Search;

namespace RSM.WEB.Services.Interface
{
    public interface IProductService
    {
        Task<List<SearchProductResponse>> GetAllProductsInformation();
        Task<List<GetSalesReportResponse>> GetFirstSalesReport(FilterInformationRequest request);
    }
}
