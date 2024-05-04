using System.Net.Http.Headers;
using System.Net.Http.Json;
using RSM.SHARED.Utility;
using Microsoft.Extensions.Options;

namespace RSM.SHARED.HttpRest.Implementation
{
	public class RequestService : IRequestService
	{
		public Uri BaseUri { get; set; }
		private readonly ResponseServiceBuilder _restHelper;

		public RequestService(IOptions<AppSettingsServices> appSettingsServices)
		{
			BaseUri = new Uri(appSettingsServices.Value.UrlBase);
			_restHelper = new ResponseServiceBuilder();
		}

		public async Task<TResponse> RequestRawAsync<TResponse>(string resourceUri, HttpMethod httpMethod, object data = null)
		{
			var responseMessage = await CommonRequest(resourceUri, httpMethod, data);
			var rawResult = await responseMessage.Content.ReadFromJsonAsync<TResponse>();
			return rawResult;
		}

		private async Task<HttpResponseMessage> CommonRequest(string resourceUri, HttpMethod httpMethod, object data = null, string token = null)
		{

			using (var httpClient = new HttpClient())
			{
				httpClient.BaseAddress = this.BaseUri;
				httpClient.Timeout = GetTimeOut();
				httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
				httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("text/plain"));

				if (!string.IsNullOrEmpty(token))
				{
					httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
				}

				var request = new HttpRequestMessage()
				{
					RequestUri = new Uri(httpClient.BaseAddress, resourceUri),
					Method = httpMethod,
				};

				HttpResponseMessage response = null;
				try
				{
					switch (httpMethod.Method)
					{
						case "GET":
							response = await httpClient.GetAsync(request.RequestUri);
							break;
						case "POST":
							response = await httpClient.PostAsJsonAsync(request.RequestUri, data);
							break;
						case "PUT":
							response = await httpClient.PutAsJsonAsync(request.RequestUri, data);
							break;
						case "DELETE":
							response = await httpClient.DeleteAsync(request.RequestUri);
							break;
						default:
							throw new ArgumentOutOfRangeException(nameof(httpMethod), "El parámetro proporcionado no es parte de la enumeración.");
					}
				}
				catch (System.Exception ex)
				{
					throw;
				}
				return response;
			}
		}

		private static TimeSpan GetTimeOut()
		{
			var currentEnvironment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");
			var timeOut = TimeSpan.FromMinutes(5);

			if (currentEnvironment == "Development")
			{
				timeOut = TimeSpan.FromHours(1);
			}

			return timeOut;
		}

		public async Task<ResponseService<TResponse>> RequestRestResultAsync<TResponse>(string resourceUri, HttpMethod httpMethod, object data = null)
		{

			var responseMessage = await CommonRequest(resourceUri, httpMethod, data);
			var restResult = await _restHelper.DeserializeResponse<TResponse>(responseMessage);

			return restResult;
		}
	}
}
