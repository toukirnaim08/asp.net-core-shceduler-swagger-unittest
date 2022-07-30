using System;
namespace asp.net_core_shceduler_swagger_unittest_.Services
{
	public interface IHttpProvider
	{
		void SetMessageHandler(HttpMessageHandler? Handler);
		HttpClient? GetHttpClient();
		Task<HttpResponseMessage> GetAsync(String url);
	}
}

