using AutoMapper;
using RSM.BL.IServices;
using RSM.DAL.Interface;
using RSM.EN.DTO.SalesOrderDetail.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BL.Services
{
	public class SalesOrderDetailService : ISalesOrderDetailService
	{
		private readonly ISalesOrderDetailRepository _salesOrderDetailRepository;
		private readonly IMapper _mapper;

        public SalesOrderDetailService(ISalesOrderDetailRepository salesOrderDetailRepository, IMapper mapper)
        {
            _salesOrderDetailRepository = salesOrderDetailRepository;
			_mapper = mapper;
        }

        public async Task<List<SearchSalesOrderDetailResponse>> GetAllInformationSalesOrderDetail()
		{
			List<SearchSalesOrderDetailResponse> information = _mapper.Map<List<SearchSalesOrderDetailResponse>>( await _salesOrderDetailRepository.GetAllInformation());
			return information ?? new List<SearchSalesOrderDetailResponse>();
		}
	}
}
