using Microsoft.EntityFrameworkCore;
using RSM.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.DAL.Context
{
	public class FinalTestDbContext : DbContext
	{
		public FinalTestDbContext() 
		{
		}

		public FinalTestDbContext(DbContextOptions<FinalTestDbContext> options)
		: base(options) 
		{

		}

		public DbSet<Product> Product { get; set; }
		public DbSet<ProductCategory> ProductCategory { get; set; }
		public DbSet<ProductSubcategory> ProductSubcategory { get; set; }
		public DbSet<SalesOrderDetail> SalesOrderDetail { get; set; }
		public DbSet<SalesOrderHeader> SalesOrderHeader { get; set; }
		public DbSet<SalesTerritory> SalesTerritory { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.Entity<Product>(entity => 
			{
				entity.ToTable(nameof(Product), "Production");

				entity.HasKey(e => e.ProductID);
				entity.Property(e => e.Name).IsRequired(true);
				entity.Property(e => e.ProductNumber).IsRequired(true);
				entity.Property(e => e.MakeFlag).IsRequired(true);
				entity.Property(e => e.FinishedGoodsFlag).IsRequired(true);
				entity.Property(e => e.Color).IsRequired(false);
				entity.Property(e => e.SafetyStockLevel).IsRequired(true);
				entity.Property(e => e.ReorderPoint).IsRequired(true);
				entity.Property(e => e.StandardCost).IsRequired(true);
				entity.Property(e => e.ListPrice).IsRequired(true);
				entity.Property(e => e.Size).IsRequired(false);
				entity.Property(e => e.SizeUnitMeasureCode).IsRequired(false);
				entity.Property(e => e.Weight).IsRequired(false);
				entity.Property(e => e.WeightUnitMeasureCode).IsRequired(false);
				entity.Property(e => e.DaysToManufacture).IsRequired(true);
				entity.Property(e => e.ProductLine).IsRequired(false);
				entity.Property(e => e.Class).IsRequired(false);
				entity.Property(e => e.Style).IsRequired(false);
				entity.Property(e => e.SellStartDate).IsRequired(true);
				entity.Property(e => e.SellEndDate).IsRequired(false);
				entity.Property(e => e.DiscontinuedDate).IsRequired(false);
				entity.Property(e => e.rowguid).IsRequired(true);
				entity.Property(e => e.ModifiedDate).IsRequired(true);

				entity.HasOne(c => c.ProductSubcategory)
						.WithMany(c => c.Product)
						.HasForeignKey(c => c.ProductSubcategoryID)
						.HasPrincipalKey(c => c.ProductSubcategoryID);
			});

			modelBuilder.Entity<ProductCategory>(entity => 
			{
				entity.ToTable(nameof(ProductCategory), "Production");

				entity.HasKey(e => e.ProductCategoryID);
				entity.Property(e => e.Name).IsRequired(true);
				entity.Property(e => e.rowguid).IsRequired(true);
				entity.Property(e => e.ModifiedDate).IsRequired(true);
			});

			modelBuilder.Entity<ProductSubcategory>(entity => 
			{
				entity.ToTable(nameof(ProductSubcategory), "Production");

				entity.HasKey(e => e.ProductSubcategoryID);
				entity.Property(e => e.Name).IsRequired(true);
				entity.Property(e => e.rowguid).IsRequired(true);
				entity.Property(e => e.ModifiedDate).IsRequired(true);

				entity.HasOne(c => c.ProductCategory)
						.WithMany(c => c.ProductSubcategories)
						.HasForeignKey(c => c.ProductCategoryID)
						.HasPrincipalKey(c => c.ProductCategoryID);
			});

			modelBuilder.Entity<SalesOrderDetail>(entity => 
			{
				entity.ToTable(nameof(SalesOrderDetail), "Sales");

				entity.HasKey(e => e.SalesOrderDetailID);
				entity.Property(e => e.CarrierTrackingNumber).IsRequired(false);
				entity.Property(e => e.OrderQty).IsRequired(true);
				entity.Property(e => e.UnitPrice).IsRequired(true);
				entity.Property(e => e.UnitPriceDiscount).IsRequired(true);
				entity.Property(e => e.LineTotal).IsRequired(true);
				entity.Property(e => e.rowguid).IsRequired(true);
				entity.Property(e => e.ModifiedDate).IsRequired(true);

				entity.HasOne(c => c.Product)
						.WithMany(c => c.SalesOrderDetails)
						.HasForeignKey(c => c.ProductID)
						.HasPrincipalKey(c => c.ProductID);

				entity.HasOne(c => c.SalesOrderHeader)
						.WithMany(c => c.SalesOrderDetails)
						.HasForeignKey(c => c.SalesOrderID)
						.HasPrincipalKey(c => c.SalesOrderID);
			});

			modelBuilder.Entity<SalesTerritory>(entity => 
			{
				entity.ToTable(nameof(SalesTerritory), "Sales");

				entity.HasKey(e => e.TerritoryID);
				entity.Property(e => e.Name).IsRequired(true);
				entity.Property(e => e.CountryRegionCode).IsRequired(true);
				entity.Property(e => e.Group).IsRequired(true);
				entity.Property(e => e.SalesYTD).IsRequired(true);
				entity.Property(e => e.SalesLastYear).IsRequired(true);
				entity.Property(e => e.CostYTD).IsRequired(true);
				entity.Property(e => e.rowguid).IsRequired(true);
				entity.Property(e => e.ModifiedDate).IsRequired(true);
			});

			modelBuilder.Entity<SalesOrderHeader>(entity => 
			{
				entity.ToTable(nameof(SalesOrderHeader), "Sales");

				entity.HasKey(e => e.SalesOrderID);
				entity.Property(e => e.RevisionNumber).IsRequired(true);
				entity.Property(e => e.OrderDate).IsRequired(true);
				entity.Property(e => e.DueDate).IsRequired(true);
				entity.Property(e => e.ShipDate).IsRequired(false);
				entity.Property(e => e.Status).IsRequired(true);
				entity.Property(e => e.OnlineOrderFlag).IsRequired(true);
				entity.Property(e => e.SalesOrderNumber).IsRequired(true);
				entity.Property(e => e.PurchaseOrderNumber).IsRequired(false);
				entity.Property(e => e.AccountNumber).IsRequired(false);
				entity.Property(e => e.CreditCardApprovalCode).IsRequired(false);
				entity.Property(e => e.SubTotal).IsRequired(true);
				entity.Property(e => e.TaxAmt).IsRequired(true);
				entity.Property(e => e.Freight).IsRequired(true);
				entity.Property(e => e.TotalDue).IsRequired(true);
				entity.Property(e => e.Comment).IsRequired(false);
				entity.Property(e => e.rowguid).IsRequired(true);
				entity.Property(e => e.ModifiedDate).IsRequired(true);
				entity.Property(e => e.TerritoryID).IsRequired(false);

				entity.HasOne(c => c.Territory)
						.WithMany(c => c.SalesOrderHeaders)
						.HasForeignKey(c => c.TerritoryID)
						.HasPrincipalKey(c => c.TerritoryID);
			});
		}
	}
}
