using AutoMapper;
using RSM.BL.IServices;
using RSM.DAL.Interface;
using RSM.EN.DTO.ProductSubcategory.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BL.Services
{
	public class ProductSubcategoryService : IProductSubcategoryService
	{
		private readonly IProductSubcategoryRepository _productSubcategoryRepository;
		private readonly IMapper _mapper;

        public ProductSubcategoryService(IProductSubcategoryRepository productSubcategoryRepository, IMapper mapper)
        {
            _productSubcategoryRepository = productSubcategoryRepository;
			_mapper = mapper;
        }

        public async Task<List<SearchProductSubcategoryResponse>> GetAllInformationProductSubcategory()
		{
			List<SearchProductSubcategoryResponse> information = _mapper.Map<List<SearchProductSubcategoryResponse>>(await _productSubcategoryRepository.GetAllInformation());
			return information ?? new List<SearchProductSubcategoryResponse>();
		}
	}
}
