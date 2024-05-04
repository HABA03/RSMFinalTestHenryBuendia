using AutoMapper;
using RSM.BL.IServices;
using RSM.DAL.Interface;
using RSM.EN.DTO.Customer.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BL.Services
{
	public class CustomerService : ICustomerService
	{
		private readonly ICustomerRepository _customerRepository;
		private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
			_mapper = mapper;
        }

        public async Task<List<SearchCustomerResponse>> GetAllInformationCustomer()
		{
			List<SearchCustomerResponse> information = _mapper.Map<List<SearchCustomerResponse>>( await _customerRepository.GetAllInformation());
			return information ?? new List<SearchCustomerResponse>();
		}
	}
}
