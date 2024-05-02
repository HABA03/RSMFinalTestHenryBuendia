using Microsoft.EntityFrameworkCore;
using RSM.DAL.Context;
using RSM.DAL.Interface;
using RSM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.DAL.Implementation
{
	public class ProductRepository : IProductRepository
	{
		private FinalTestDbContext _context;

		public ProductRepository(FinalTestDbContext context)
		{
			_context = context;
		}

		public async Task<List<Product>> GetAllInformation()
		{
			var result = await _context.Set<Product>().Take(10).ToListAsync();
			return result;
		}

		public async Task<List<SalesReportInformation1>> GetReportInformation()
		{
			var resultado = await _context.Product
			.Join(_context.ProductSubcategory, product => product.ProductSubcategoryID, subcategory => subcategory.ProductSubcategoryID, (product, subcategory) => new { Product = product, Subcategory = subcategory })
			.Join(_context.ProductCategory, temp => temp.Subcategory.ProductCategoryID, category => category.ProductCategoryID, (temp, category) => new { temp.Product, Category = category })
			.Join(_context.SalesOrderDetail, temp => temp.Product.ProductID, detail => detail.ProductID, (temp, detail) => new { temp.Product, temp.Category, Detail = detail })
			.Join(_context.SalesOrderHeader, temp => temp.Detail.SalesOrderID, header => header.SalesOrderID, (temp, header) => new { temp.Product, temp.Category, temp.Detail, Header = header })
			.Join(_context.SalesTerritory, temp => temp.Header.TerritoryID, territory => territory.TerritoryID, (temp, territory) => new { temp.Product, temp.Category, temp.Detail, temp.Header, Region = territory.Name })
			.Select(result => new SalesReportInformation1
			{
				ProductID = result.Product.ProductID,
				ProductName = result.Product.Name,
				CategoryName = result.Category.Name,
				TotalSales = result.Detail.OrderQty * result.Detail.UnitPrice,
				Region = result.Region
			})
			.Take(100)
			.ToListAsync();

			decimal totalSales = resultado.Sum(item => item.TotalSales);

			return resultado.Select(result => new SalesReportInformation1
			{
				ProductID = result.ProductID,
				ProductName = result.ProductName,
				CategoryName = result.CategoryName,
				TotalSales = result.TotalSales,
				Region = result.Region,
				PercentageOfTotalSalesInRegion = Math.Round((result.TotalSales * 100.0M) / totalSales, 2),
				PercentageOfTotalCategorySalesInRegion = Math.Round((result.TotalSales * 100.0M) / resultado.Where(item => item.CategoryName == result.CategoryName && item.Region == result.Region).Sum(item => item.TotalSales), 2)
			}).Take(100).ToList();
		}
	}
}
