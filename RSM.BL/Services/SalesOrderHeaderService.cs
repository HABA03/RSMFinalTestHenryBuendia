using RSM.BL.IServices;
using RSM.DAL.Interface;
using RSM.EN.DTO.SalesOrderHeader.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace RSM.BL.Services
{
	public class SalesOrderHeaderService : ISalesOrderHeaderService
	{
		private readonly ISalesOrderHeaderRepository _salesOrderHeaderRepository;
		private readonly IMapper _mapper;
        public SalesOrderHeaderService(ISalesOrderHeaderRepository salesOrderHeaderRepository, IMapper mapper)
        {
            _salesOrderHeaderRepository = salesOrderHeaderRepository;
			_mapper = mapper;
        }

        public async Task<List<SearchSalesOrderHeeaderResponse>> GetAllInformationSalesOrderHeader()
		{
			List<SearchSalesOrderHeeaderResponse> information = _mapper.Map<List<SearchSalesOrderHeeaderResponse>>(await _salesOrderHeaderRepository.GetAllInformation());
			return information ?? new List<SearchSalesOrderHeeaderResponse>();
		}
	}
}
