using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using RSM.WEB;
using RSM.WEB.Services.Implementation;
using RSM.WEB.Services.Interface;
using Syncfusion.Blazor;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MzI1NTg5NEAzMjM1MmUzMDJlMzBGKzhER3lSVTFUOFlVRDd4UTEzTGwzUnhZakVnSkxIQ2l3dGx2Z1IvdEJ3PQ==");

builder.Services.AddSyncfusionBlazor();
builder.Services.AddTransient<IProductCategoryService, ProductCategoryService>();
builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<ISalesOrderHeaderService, SalesOrderHeaderService>();
builder.Services.AddTransient<IPersonService, PersonService>();
builder.Services.AddTransient<IProductSubcategoryService, ProductSubcategoryService>();
builder.Services.AddTransient<ISalesOrderDetailService, SalesOrderDetailService>();
builder.Services.AddTransient<ISalesTerritoryService, SalesTerritoryService>();
builder.Services.AddTransient<ICustomerService, CustomerService>();

await builder.Build().RunAsync();