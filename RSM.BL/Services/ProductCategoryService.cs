using AutoMapper;
using RSM.BL.IServices;
using RSM.DAL.Interface;
using RSM.EN.DTO.ProductCategory.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BL.Services
{
	public class ProductCategoryService : IProductCategoryService
	{
		private readonly IProductCategoryRepository _productCategory;
		private readonly IMapper _mapper;

        public ProductCategoryService(IProductCategoryRepository productCategory, IMapper mapper)
        {
            _productCategory = productCategory;
			_mapper = mapper;
        }

        public async Task<List<SearchProductCategoryResponse>> GetAllInformationProductCategory()
		{
			List<SearchProductCategoryResponse> information = _mapper.Map<List<SearchProductCategoryResponse>>(await _productCategory.GetAllInformation());
			return information ?? new List<SearchProductCategoryResponse>();
		}
	}
}
