using AutoMapper;
using RSM.BL.IServices;
using RSM.DAL.Interface;
using RSM.EN.DTO.Person.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BL.Services
{
	public class PersonService : IPersonService
	{
		private readonly IPersonRepository _personRepository;
		private readonly IMapper _mapper;

        public PersonService(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
			_mapper = mapper;
        }

        public async Task<List<SearchPersonResponse>> GetAllInformationPerson()
		{
			List<SearchPersonResponse> information = _mapper.Map<List<SearchPersonResponse>>(await _personRepository.GetAllInformation());
			return information ?? new List<SearchPersonResponse>();
		}
	}
}
