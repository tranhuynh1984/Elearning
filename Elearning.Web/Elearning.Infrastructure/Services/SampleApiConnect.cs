using Elearning.Infrastructure.Constants;
using Elearning.Infrastructure.Contracts;
using Microsoft.Extensions.Logging;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Elearning.Infrastructure.Services
{
    public class SampleApiConnect : IApiConnect
    {
		private readonly HttpClient _httpClient;
		private readonly ILogger<SampleApiConnect> _logger;
		public SampleApiConnect(HttpClient httpClient, ILogger<SampleApiConnect> logger)
		{
			_httpClient = httpClient;
			_logger = logger;
		}

		public async Task<SampleResponse> PostDataAsync<SampleResponse, SampleRequest>(string endPoint, SampleRequest dto)
		{
			var content = new StringContent(JsonSerializer.Serialize(dto), Encoding.UTF8, HttpContentMediaTypes.JSON);
			var httpResponse = await _httpClient.PostAsync(endPoint, content);

			if (!httpResponse.IsSuccessStatusCode)
			{
				_logger.Log(LogLevel.Warning, $"[{httpResponse.StatusCode}] An error occured while requesting external api.");
				return default;
			}

			var jsonString = await httpResponse.Content.ReadAsStringAsync();
			var data = JsonSerializer.Deserialize<SampleResponse>(jsonString);

			return data;
		}

		public async Task<SampleResponse> GetDataAsync<SampleResponse>(string endPoint)
		{
			var httpResponse = await _httpClient.GetAsync(endPoint);

			if (!httpResponse.IsSuccessStatusCode)
			{
				_logger.Log(LogLevel.Warning, $"[{httpResponse.StatusCode}] An error occured while requesting external api.");
				return default;
			}

			var jsonString = await httpResponse.Content.ReadAsStringAsync();
			var data = JsonSerializer.Deserialize<SampleResponse>(jsonString);

			return data;
		}
	}
}
