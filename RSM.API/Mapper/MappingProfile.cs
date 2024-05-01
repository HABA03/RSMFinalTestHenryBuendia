using AutoMapper;
using RSM.DAL.Models;
using RSM.EN.DTO.Product.Search;
using RSM.EN.DTO.ProductCategory.Search;
using RSM.EN.DTO.ProductSubcategory.Search;
using RSM.EN.DTO.SalesOrderDetail.Search;
using RSM.EN.DTO.SalesOrderHeader.Search;
using RSM.EN.DTO.SalesTerritory.Search;

namespace RSM.API.Mapper
{
	public class MappingProfile : Profile
	{
		public MappingProfile() 
		{
			CreateMap<SearchSalesOrderHeeaderResponse, SalesOrderHeader>().ReverseMap();

			CreateMap<SearchProductCategoryResponse, ProductCategory>().ReverseMap();

			CreateMap<SearchSalesTerritoryResponse, SalesTerritory>().ReverseMap();

			CreateMap<SearchSalesOrderDetailResponse, SalesOrderDetail>().ReverseMap();

			CreateMap<SearchProductResponse, Product>().ReverseMap();

			CreateMap<SearchProductSubcategoryResponse, ProductSubcategory>().ReverseMap();
		}
	}
}
