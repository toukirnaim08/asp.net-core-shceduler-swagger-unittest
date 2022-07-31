using System;

namespace asp.net_core_shceduler_swagger_unittest.Services
{
	public class HttpProvider : IHttpProvider
	{
		private HttpClient? _client;

		public HttpProvider()
		{
			_client = new HttpClient();
		}

		public void SetMessageHandler(HttpMessageHandler? Handler)
		{

			_client = new HttpClient(Handler);
		}

		public HttpClient? GetHttpClient()
		{
			return _client;
		}

		public async Task<HttpResponseMessage> GetAsync(String url)
		{
			var response = await _client.GetAsync(url);
			return response;
		}

	}
}

