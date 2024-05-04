using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM.EN.Routes
{
	public class Routes
	{
		public const string ApiVersion = "v1";
		public const string ApiBase = "/api/" + ApiVersion;

		public struct SalesOrderHeader 
		{
			public const string Controller = ApiBase + "/SalesOrderHeader/";
			public const string GetAllInformationSalesOrderHeader = Controller + "GetAllInformation/";
			public const string GetSalesReport = Controller + "GetSalesReport2Information/";
            public const string GeneratePdf = Controller + "GenerateSalesReport2Pdf/";
        }

		public struct Product 
		{
			public const string Controller = ApiBase + "/Product/";
			public const string GetAllInformationProduct = Controller + "GetAllInformation";
			public const string GetSalesReport = Controller + "GetSalesReport1Information/";
            public const string GeneratePdf = Controller + "GenerateSalesReport1Pdf/";
        }

		public struct ProductCategory 
		{
			public const string Controller = ApiBase + "/ProductCategory/";
			public const string GetAllInformationProductCategory = Controller + "GetAllInformation";
		}

		public struct ProductSubcategory
		{
			public const string Controller = ApiBase + "/ProductSubcategory/";
			public const string GetAllInformationProductSubCategory = Controller + "GetAllInformation/";
		}

		public struct SalesOrderDetail
		{
			public const string Controller = ApiBase + "/SalesOrderDetail/";
			public const string GetAllInformationSalesOrderDetail = Controller + "GetAllInformation/";
		}

		public struct SalesTerritory
		{
			public const string Controller = ApiBase + "/SalesTerritory/";
			public const string GetAllInformationSalesTerritory = Controller + "GetAllInformation/";
		}

		public struct Customer
		{
			public const string Controller = ApiBase + "/Customer/";
			public const string GetAllInformationCustomers = Controller + "GetAllInformation/";
        }

		public struct Person
		{
			public const string Controller = ApiBase + "/Person/";
			public const string GetAllInformationPerson = Controller + "GetAllInformation/";
		}
	}
}
