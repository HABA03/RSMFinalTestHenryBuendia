using AutoMapper;
using RSM.BL.IServices;
using RSM.DAL.Interface;
using RSM.EN.DTO.Product.GetSalesReport;
using RSM.EN.DTO.Product.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BL.Services
{
	public class ProductService : IProductService
	{
		private readonly IProductRepository _productRepository;
		private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
			_mapper = mapper;
        }

        public async Task<List<SearchProductResponse>> GetAllInformationProduct()
		{
			List<SearchProductResponse> information = _mapper.Map<List<SearchProductResponse>>( await _productRepository.GetAllInformation());
			return information ?? new List<SearchProductResponse>();
		}

		public async Task<List<GetSalesReportResponse>> GetSalesReport()
		{
			List<GetSalesReportResponse> information = _mapper.Map<List<GetSalesReportResponse>>( await _productRepository.GetReportInformation());
			return information ?? new List<GetSalesReportResponse>();
		}
	}
}
