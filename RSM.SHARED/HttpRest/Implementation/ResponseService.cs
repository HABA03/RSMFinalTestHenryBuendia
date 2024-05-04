using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RSM.SHARED.HttpRest.Implementation
{
	public class ResponseService<TResponse>
	{
		public ResponseService()
		{

		}
		public ResponseService(string Message, TResponse Result, HttpStatusCode StatusCode, string Version)
		{
			this.Message = Message;
			this.Result = Result;
			this.StatusCode = StatusCode;
			this.Version = Version;
		}


		[JsonPropertyName("version")]
		public string Version { get; set; }

		[JsonPropertyName("statusCode")]
		public HttpStatusCode StatusCode { get; set; }

		[JsonPropertyName("message")]
		public string Message { get; set; }

		[JsonPropertyName("isError")]
		public bool IsError { get; set; } = false;

		[JsonPropertyName("result")]
		public TResponse Result { get; set; }
	}
}
