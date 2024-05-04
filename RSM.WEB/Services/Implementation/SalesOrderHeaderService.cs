using RSM.EN.DTO.Helper.Filter;
using RSM.EN.DTO.PdfSalesReport2Information.CreatePdfInformation;
using RSM.EN.DTO.Product.Search;
using RSM.EN.DTO.SalesOrderHeader.GetSalesReport;
using RSM.EN.DTO.SalesOrderHeader.Search;
using RSM.EN.Routes;
using RSM.WEB.Services.Interface;
using System.Net.Http.Json;
using System.Text.Json;

namespace RSM.WEB.Services.Implementation
{
    public class SalesOrderHeaderService : ISalesOrderHeaderService
    {
        private readonly HttpClient _httpClient;
        string apiLocalHost = "https://localhost:7141";

        public SalesOrderHeaderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CreatePdfInformationResponse> GeneratePdf(List<CreatePdfInformationRequest> request)
        {
            string api = $"{apiLocalHost + Routes.SalesOrderHeader.GeneratePdf}";
            var response = await _httpClient.PostAsJsonAsync(api, request);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<CreatePdfInformationResponse>();
                return result ?? new CreatePdfInformationResponse();
            }
            else
            {
                throw new Exception($"Error getting response from server. Status code: {response.StatusCode}");
            }
        }

        public async Task<List<SearchSalesOrderHeeaderResponse>> GetAllInformationSalesOrderHeader()
        {
            string api = apiLocalHost + Routes.SalesOrderHeader.GetAllInformationSalesOrderHeader;
            var result = await _httpClient.GetFromJsonAsync<List<SearchSalesOrderHeeaderResponse>>(api);
            return result ?? new List<SearchSalesOrderHeeaderResponse>();
        }

        public async Task<List<GetTheSalesReportResponse>> GetSecondSalesReport(FilterInformationRequest request)
        {
            string api = $"{apiLocalHost + Routes.SalesOrderHeader.GetSalesReport}";
            var response = await _httpClient.PostAsJsonAsync(api, request);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<List<GetTheSalesReportResponse>>();
                return result ?? new List<GetTheSalesReportResponse>();
            }
            else
            {
                throw new Exception($"Error getting response from server. Status code: {response.StatusCode}");
            }
        }
    }
}
