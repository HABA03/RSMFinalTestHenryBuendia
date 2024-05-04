using RSM.EN.DTO.Helper.Filter;
using RSM.EN.DTO.PdfSalesReport1Information.CreatePdf;
using RSM.EN.DTO.Product.GetSalesReport;
using RSM.EN.DTO.Product.Search;
using RSM.EN.DTO.ProductCategory.Search;
using RSM.EN.DTO.SalesOrderHeader.GetSalesReport;
using RSM.EN.Routes;
using RSM.WEB.Services.Interface;
using System.Net.Http.Json;

namespace RSM.WEB.Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        string apiLocalHost = "https://localhost:7141";

        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CreatePdfResponse> GeneratePdf(List<CreatePdfRequest> request)
        {
            string api = $"{apiLocalHost + Routes.Product.GeneratePdf}";
            var response = await _httpClient.PostAsJsonAsync(api, request);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<CreatePdfResponse>();
                return result ?? new CreatePdfResponse();
            }
            else
            {
                throw new Exception($"Error al obtener la respuesta del servidor. Código de estado: {response.StatusCode}");
            }
        }

        public async Task<List<SearchProductResponse>> GetAllProductsInformation()
        {
            string api = apiLocalHost + Routes.Product.GetAllInformationProduct;
            var result = await _httpClient.GetFromJsonAsync<List<SearchProductResponse>>(api);
            return result ?? new List<SearchProductResponse>();
        }

        public async Task<List<GetSalesReportResponse>> GetFirstSalesReport(FilterInformationRequest request)
        {
            string api = $"{apiLocalHost + Routes.Product.GetSalesReport}";
            var response = await _httpClient.PostAsJsonAsync(api, request);

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<List<GetSalesReportResponse>>();
                return result ?? new List<GetSalesReportResponse>();
            }
            else
            {
                throw new Exception($"Error al obtener la respuesta del servidor. Código de estado: {response.StatusCode}");
            }
        }
    }
}
