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
using System.Xml.Schema;

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
                    page.Header().Text("First Sales Report")
                        .FontSize(30)
                        .Bold()
                        .AlignCenter();

                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(x => 
                        {
                            x.Spacing(8);
                            foreach (var item in request)
                            {
                                x.Item().PaddingLeft(35).Text($"Product ID: {item.ProductID}").FontSize(13).Bold();
                                x.Item().PaddingLeft(35).Text($"Product Name: {item.ProductName}").FontSize(13).Bold();
                                x.Item().PaddingLeft(35).Text($"Category Name: {item.CategoryName}").FontSize(13).Bold();
                                x.Item().PaddingLeft(35).Text($"Total Sales: {item.TotalSales}").FontSize(13).Bold();
                                x.Item().PaddingLeft(35).Text($"Region: {item.Region}").FontSize(13).Bold();
                                x.Item().PaddingLeft(35).Text($"Percentage Of Total Sales In Region: {item.PercentageOfTotalSalesInRegion}").FontSize(13).Bold();
                                x.Item().PaddingLeft(35).Text($"Percentage Of Total Category Sales In Region: {item.PercentageOfTotalCategorySalesInRegion}").FontSize(13).Bold();
                                x.Item().Text("-------------------------------------------------------------------------------------------------------------------------------------");
                            }
                        });

                       
                });
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
                    page.Header().Text("Second Sales Report")
                        .FontSize(30)
                        .Bold()
                        .AlignCenter();

                    page.Content()
                        .PaddingVertical(1, Unit.Centimetre)
                        .Column(x =>
                        {
                            x.Spacing(11);
                            foreach (var item in request)
                            {
                                x.Item().PaddingLeft(35).Text($"Order ID: {item.OrderID}").FontSize(13).Bold();
                                x.Item().PaddingLeft(35).Text($"Order Date: {item.OrderDate}").FontSize(13).Bold();
                                x.Item().PaddingLeft(35).Text($"Customer ID: {item.CustomerID}").FontSize(13).Bold();
                                x.Item().PaddingLeft(35).Text($"Product ID: {item.ProductID}").FontSize(13).Bold();
                                x.Item().PaddingLeft(35).Text($"Product Name: {item.ProductName}").FontSize(13).Bold();
                                x.Item().PaddingLeft(35).Text($"Product Category: {item.ProductCategory}").FontSize(13).Bold();
                                x.Item().PaddingLeft(35).Text($"Unit Price: {item.UnitPrice}").FontSize(13).Bold();
                                x.Item().PaddingLeft(35).Text($"Quantity: {item.Quantity}").FontSize(13).Bold();
                                x.Item().PaddingLeft(35).Text($"Total Price: {item.TotalPrice}").FontSize(13).Bold();
                                x.Item().PaddingLeft(35).Text($"Sales Person ID: {item.SalesPersonID}").FontSize(13).Bold();
                                x.Item().PaddingLeft(35).Text($"Sales Person Name: {item.SalesPersonName}").FontSize(13).Bold();
                                x.Item().PaddingLeft(35).Text($"Ship To Address ID: {item.ShipToAddressID}").FontSize(13).Bold();
                                x.Item().PaddingLeft(35).Text($"Bill To Address ID: {item.BillToAddressID}").FontSize(13).Bold();
                                x.Item().Text("-------------------------------------------------------------------------------------------------------------------------------------");
                            }
                        });


                });
            }).GeneratePdf(@"C:\Users\henry\Desktop\Meditaciones Pastor Marquez\SecondSalesReport.pdf");
            return response;
        }
    }
}
