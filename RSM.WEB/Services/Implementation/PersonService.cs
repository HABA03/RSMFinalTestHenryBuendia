using RSM.EN.DTO.Person.Search;
using RSM.EN.DTO.ProductCategory.Search;
using RSM.EN.Routes;
using RSM.WEB.Services.Interface;
using System.Net.Http.Json;

namespace RSM.WEB.Services.Implementation
{
    public class PersonService : IPersonService
    {
        private readonly HttpClient _httpClient;
        string apiLocalHost = "https://localhost:7141";

        public PersonService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<SearchPersonResponse>> GetPeopleInformation()
        {
            string api = apiLocalHost + Routes.Person.GetAllInformationPerson;
            var result = await _httpClient.GetFromJsonAsync<List<SearchPersonResponse>>(api);
            return result ?? new List<SearchPersonResponse>();
        }
    }
}
