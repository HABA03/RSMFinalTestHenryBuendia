using RSM.EN.DTO.Customer.Search;
using RSM.EN.DTO.Product.Search;
using RSM.EN.Routes;
using RSM.WEB.Services.Interface;
using System.Net.Http.Json;

namespace RSM.WEB.Services.Implementation
{
    public class CustomerService : ICustomerService
    {
        private readonly HttpClient _httpClient;
        string apiLocalHost = "https://localhost:7141";

        public CustomerService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }


        public async Task<List<SearchCustomerResponse>> GetCustomerInformation()
        {
            string api = apiLocalHost + Routes.Customer.GetAllInformationCustomers;
            var result = await _httpClient.GetFromJsonAsync<List<SearchCustomerResponse>>(api);
            return result ?? new List<SearchCustomerResponse>();
        }
    }
}
