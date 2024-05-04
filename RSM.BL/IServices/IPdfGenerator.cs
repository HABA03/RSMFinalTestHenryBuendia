using RSM.EN.DTO.PdfSalesReport1Information.CreatePdf;
using RSM.EN.DTO.PdfSalesReport2Information.CreatePdfInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BL.IServices
{
    public interface IPdfGenerator
    {
        Task<CreatePdfResponse> CreatePdf1(List<CreatePdfRequest> request);
        Task<CreatePdfInformationResponse> CreatePdf2(List<CreatePdfInformationRequest> request);
    }
}
