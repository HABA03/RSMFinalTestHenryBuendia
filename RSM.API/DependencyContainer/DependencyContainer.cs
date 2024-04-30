using RSM.BL.IServices;
using RSM.BL.Services;
using RSM.DAL.Interface;
using RSM.DAL.Implementation;

namespace RSM.API.DependencyContainer
{
	public class DependencyContainer
	{
		public static void RegisterServices(IServiceCollection services)
		{
			//Services
			services.AddScoped<ISalesOrderHeaderService, SalesOrderHeaderService>();
			services.AddScoped<IProductCategoryService, ProductCategoryService>();
			services.AddScoped<ISalesTerritoryService, SalesTerritoryService>();
			services.AddScoped<ISalesOrderDetailService, SalesOrderDetailService>();
			services.AddScoped<IProductService, ProductService>();

			//Repositories
			services.AddTransient<ISalesOrderHeaderRepository, SalesOrderHeaderRepository>();
			services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();
			services.AddTransient<ISalesTerrirotyRepository, SalesTerritoryRepository>();
			services.AddTransient<ISalesOrderDetailRepository, SalesOrderDetailRepository>();
			services.AddTransient<IProductRepository, ProductRepository>();
		}
	}
}
