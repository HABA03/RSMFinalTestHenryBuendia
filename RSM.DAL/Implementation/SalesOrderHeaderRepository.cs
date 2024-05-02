using RSM.DAL.Context;
using RSM.DAL.Interface;
using RSM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RSM.EN.DTO.SalesOrderHeader.GetSalesReport;

namespace RSM.DAL.Implementation
{
	public class SalesOrderHeaderRepository : ISalesOrderHeaderRepository
	{
		private FinalTestDbContext _context { get; set; }

        public SalesOrderHeaderRepository(FinalTestDbContext context)
        {
            _context = context;
        }

        public async Task<List<SalesOrderHeader>> GetAllInformation()
		{
			var result = await _context.Set<SalesOrderHeader>()
									.Include(x => x.Territory)
									.Take(10)
									.ToListAsync();
			return result;
		}

		public async Task<List<GetTheSalesReportResponse>> GetTheSalesReport()
		{
			var result = await _context.SalesOrderDetail
				.Join(_context.SalesOrderHeader,
					sod => sod.SalesOrderID,
					soh => soh.SalesOrderID,
					(sod, soh) => new { sod, soh })
				.Join(_context.Product,
					temp => temp.sod.ProductID,
					p => p.ProductID,
					(temp, p) => new { temp.sod, temp.soh, Product = p })
				.Join(_context.ProductSubcategory,
					temp => temp.Product.ProductSubcategoryID,
					ps => ps.ProductSubcategoryID,
					(temp, ps) => new { temp.sod, temp.soh, temp.Product, ProductSubcategory = ps })
				.Join(_context.ProductCategory,
					temp => temp.ProductSubcategory.ProductCategoryID,
					pc => pc.ProductCategoryID,
					(temp, pc) => new { temp.sod, temp.soh, temp.Product, temp.ProductSubcategory, ProductCategory = pc })
				.Join(_context.Customer,
					temp => temp.soh.CustomerID,
					c => c.CustomerID,
					(temp, c) => new { temp.sod, temp.soh, temp.Product, temp.ProductSubcategory, temp.ProductCategory, Customer = c })
				.Join(_context.Person,
					temp => temp.Customer.PersonID,
					p => p.BusinessEntityID,
					(temp, p) => new { temp.sod, temp.soh, temp.Product, temp.ProductSubcategory, temp.ProductCategory, temp.Customer, Person = p })
				.Select(resultado => new GetTheSalesReportResponse
				{
					OrderID = resultado.soh.SalesOrderID,
					OrderDate = resultado.soh.OrderDate,
					CustomerID = resultado.soh.CustomerID,
					ProductID = resultado.Product.ProductID,
					ProductName = resultado.Product.Name,
					ProductCategory = resultado.ProductCategory.Name,
					UnitPrice = resultado.sod.UnitPrice,
					Quantity = resultado.sod.OrderQty,
					TotalPrice = resultado.sod.UnitPrice * resultado.sod.OrderQty,
					SalesPersonID = resultado.soh.SalesPersonID,
					SalesPersonName = resultado.Person.FirstName,
					ShipToAddressID = resultado.soh.ShipToAddressID,
					BillToAddressID = resultado.soh.BillToAddressID
				})
				.Take(100)
				.ToListAsync();

			return result;
		}
	}
}
