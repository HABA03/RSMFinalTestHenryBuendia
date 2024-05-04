using Microsoft.AspNetCore.Components;
using RSM.EN.DTO.Customer.Search;
using RSM.WEB.Services.Interface;

namespace RSM.WEB.Pages.Customer
{
    public partial class Customer
    {
        [Inject]
        private ICustomerService _customerService { get; set; }

        List<SearchCustomerResponse> customer = new List<SearchCustomerResponse>();

        protected async override Task OnInitializedAsync()
        {
            await GetCustomerInformation();
        }

        protected async Task GetCustomerInformation()
        {
            var response = await _customerService.GetCustomerInformation();
            if (response.Count > 0)
            {
                customer = response;
            }
        }
    }
}
