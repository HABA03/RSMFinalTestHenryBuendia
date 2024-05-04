using RSM.EN.DTO.Person.Search;

namespace RSM.WEB.Services.Interface
{
    public interface IPersonService
    {
        Task<List<SearchPersonResponse>> GetPeopleInformation();
    }
}
