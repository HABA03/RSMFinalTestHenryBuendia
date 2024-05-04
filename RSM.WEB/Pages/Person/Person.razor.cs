using Microsoft.AspNetCore.Components;
using RSM.WEB.Services.Interface;
using RSM.EN.DTO.Person.Search;

namespace RSM.WEB.Pages.Person
{
    public partial class Person
    {
        [Inject]
        private IPersonService _person { get; set; }

        List<SearchPersonResponse> searchPerson = new List<SearchPersonResponse>();

        protected async override Task OnInitializedAsync()
        {
            await GetPeopleInformation();
        }

        protected async Task GetPeopleInformation()
        {
            var response = await _person.GetPeopleInformation();
            if (response.Count > 0)
            {
                searchPerson = response;
            }
        }
    }
}
