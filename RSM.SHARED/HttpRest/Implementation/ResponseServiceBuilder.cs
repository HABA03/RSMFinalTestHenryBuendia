using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RSM.SHARED.HttpRest.Implementation
{
	public class ResponseServiceBuilder
	{
		/// <summary>
		/// Evento para suscribirse cuando ocurre un error al obtener la petición.
		/// </summary>
		public event EventHandler<System.Exception> OnDeserializeError;
		/// <summary>
		/// Evento para suscribir cuando el estado de la respuesta no es OK.
		/// </summary>
		public event EventHandler<object> OnNoOkStatusResponse;

		/// <summary>
		/// Evento para suscribirse cuando ocurre un error al serializar la respuesta.
		/// </summary>
		public event EventHandler<System.Exception> OnSerializeError;


		public ResponseServiceBuilder()
		{
		}

		public async Task<ResponseService<TEntityOut>> DeserializeResponse<TEntityOut>(HttpResponseMessage responseMessage)
		{
			ResponseService<TEntityOut> restResult;

			try
			{
				var restResultResponse = await responseMessage.Content.ReadFromJsonAsync<ResponseService<TEntityOut>>();
				restResult = restResultResponse;
				restResult.StatusCode = responseMessage.StatusCode;

				if (restResult.StatusCode != HttpStatusCode.OK)
					OnNoOkStatusResponse?.Invoke(this, restResult);

			}
			catch (System.Exception exception)
			{
				OnDeserializeError?.Invoke(this, exception);
				throw;
			}

			return restResult;
		}
	}
}
