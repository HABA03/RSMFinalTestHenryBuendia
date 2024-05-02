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
			services.AddScoped<IProductSubcategoryService,  ProductSubcategoryService>();
			services.AddScoped<ICustomerService, CustomerService>();
			services.AddScoped<IPersonService, PersonService>();

			//Repositories
			services.AddTransient<ISalesOrderHeaderRepository, SalesOrderHeaderRepository>();
			services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();
			services.AddTransient<ISalesTerrirotyRepository, SalesTerritoryRepository>();
			services.AddTransient<ISalesOrderDetailRepository, SalesOrderDetailRepository>();
			services.AddTransient<IProductRepository, ProductRepository>();
			services.AddTransient<IProductSubcategoryRepository,  ProductSubcategoryRepository>();
			services.AddTransient<ICustomerRepository, CustomerRepository>();
			services.AddTransient<IPersonRepository, PersonRepository>();
		}
	}
}
