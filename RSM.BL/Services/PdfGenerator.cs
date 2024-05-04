using RSM.BL.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QuestPDF.Infrastructure;
using QuestPDF.Fluent;
using RSM.EN.DTO.Person.Search;
using RSM.EN.DTO.PdfSalesReport1Information.CreatePdf;
using RSM.EN.DTO.PdfSalesReport2Information.CreatePdfInformation;

namespace RSM.BL.Services
{
    public class PdfGenerator : IPdfGenerator
    {
        public async Task<CreatePdfResponse> CreatePdf1(List<CreatePdfRequest> request)
        {
            CreatePdfResponse response = new CreatePdfResponse();
            response.Result = true;

            QuestPDF.Settings.License = LicenseType.Community;

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Header().Text("First Sales Report");
                });

                foreach (var item in request)
                {
                    container.Page(page =>
                    {
                        page.Content().Text($"Product ID: {item.ProductID}" +
                            $"              Produc Name: {item.ProductName}");
                        page.Content().Text($"Product Name: {item.ProductName}");
                        page.Content().Text($"Category Name: {item.CategoryName}");
                        page.Content().Text($"Total Sales: {item.TotalSales}");
                        page.Content().Text($"Region: {item.Region}");
                        page.Content().Text($"Percentage Of Total Sales In Region: {item.PercentageOfTotalSalesInRegion}");
                        page.Content().Text($"Percentage Of Total Category Sales In Region: {item.PercentageOfTotalCategorySalesInRegion}");
                        page.Content().Text($"CategoryName: {item.CategoryName}");
                    });
                }
            }).GeneratePdf(@"C:\Users\henry\Desktop\Meditaciones Pastor Marquez\FirstSalesReport.pdf");
            return response;
        }

        public async Task<CreatePdfInformationResponse> CreatePdf2(List<CreatePdfInformationRequest> request)
        {
            CreatePdfInformationResponse response = new CreatePdfInformationResponse();
            response.Result = true;

            QuestPDF.Settings.License = LicenseType.Community;

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Header().Text("Second Sales Report");
                });

                foreach (var item in request)
                {
                    container.Page(page =>
                    {
                        page.Content().Text($"Order ID: {item.OrderID}");
                        page.Content().Text($"Order Date: {item.OrderDate}");
                        page.Content().Text($"Customer ID: {item.CustomerID}");
                        page.Content().Text($"Product ID: {item.ProductID}");
                        page.Content().Text($"Product Name: {item.ProductName}");
                        page.Content().Text($"Product Category: {item.ProductCategory}");
                        page.Content().Text($"Unit Price: {item.UnitPrice}");
                        page.Content().Text($"Quantity: {item.Quantity}");
                        page.Content().Text($"Total Price: {item.TotalPrice}");
                        page.Content().Text($"Sales Person ID: {item.SalesPersonID}");
                        page.Content().Text($"Sales Person Name: {item.SalesPersonName}");
                        page.Content().Text($"Ship To Address ID: {item.ShipToAddressID}");
                        page.Content().Text($"Bill To Address ID: {item.BillToAddressID}");
                    });
                }
            }).GeneratePdf(@"C:\Users\henry\Desktop\Meditaciones Pastor Marquez\SecondSalesReport.pdf");
            return response;
        }
    }
}
