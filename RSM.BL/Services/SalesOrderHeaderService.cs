﻿using RSM.BL.IServices;
using RSM.DAL.Interface;
using RSM.EN.DTO.SalesOrderHeader.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using RSM.EN.DTO.SalesOrderHeader.GetSalesReport;
using RSM.EN.DTO.Helper.Filter;

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

		public async Task<List<GetTheSalesReportResponse>> GetTheSalesReport(FilterInformationRequest request)
		{
			List<GetTheSalesReportResponse> information = _mapper.Map<List<GetTheSalesReportResponse>>(await _salesOrderHeaderRepository.GetTheSalesReport(request.FilterID, request.Value));
			return information ?? new List<GetTheSalesReportResponse>();
		}
	}
}
