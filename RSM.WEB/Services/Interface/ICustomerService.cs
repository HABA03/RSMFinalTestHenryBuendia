using RSM.EN.DTO.Customer.Search;

namespace RSM.WEB.Services.Interface
{
    public interface ICustomerService
    {
        Task<List<SearchCustomerResponse>> GetCustomerInformation();
    }
}
