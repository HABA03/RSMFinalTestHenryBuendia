using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RSM.SHARED.HttpRest.Implementation;

namespace RSM.SHARED.HttpRest
{
	public interface IRequestService
	{
		Task<ResponseService<TResponse>> RequestRestResultAsync<TResponse>(string resourceUri, HttpMethod httpMethod, object data = null);
		Task<TResponse> RequestRawAsync<TResponse>(string resourceUri, HttpMethod httpMethod, object data = null);
	}
}
