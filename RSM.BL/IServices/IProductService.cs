﻿using RSM.EN.DTO.Helper.Filter;
using RSM.EN.DTO.Product.GetSalesReport;
using RSM.EN.DTO.Product.Search;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.BL.IServices
{
	public interface IProductService
	{
		Task<List<SearchProductResponse>> GetAllInformationProduct();
		Task<List<GetSalesReportResponse>> GetSalesReport(FilterInformationRequest request);
	}
}
