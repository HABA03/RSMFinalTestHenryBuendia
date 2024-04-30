using AutoMapper;
using RSM.BL.IServices;
using RSM.DAL.Interface;
using RSM.EN.DTO.SalesTerritory.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BL.Services
{
	public class SalesTerritoryService : ISalesTerritoryService
	{
		private readonly ISalesTerrirotyRepository _salesTerrirotyRepository;
		private readonly IMapper _mapper;

        public SalesTerritoryService(ISalesTerrirotyRepository salesTerrirotyRepository, IMapper mapper)
        {
            _salesTerrirotyRepository = salesTerrirotyRepository;
			_mapper = mapper;	
        }

        public async Task<List<SearchSalesTerritoryResponse>> GetAllInformationSalesTerritory()
		{
			List<SearchSalesTerritoryResponse> information = _mapper.Map<List<SearchSalesTerritoryResponse>>( await _salesTerrirotyRepository.GetAllInformation());
			return information ?? new List<SearchSalesTerritoryResponse>();
		}
	}
}
