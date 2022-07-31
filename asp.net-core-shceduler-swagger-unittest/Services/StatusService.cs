using System;

using asp.net_core_shceduler_swagger_unittest.Models;

namespace asp.net_core_shceduler_swagger_unittest.Services
{
	public class StatusService : IStatusService
	{
		IHttpProvider _httpProvider;

		public StatusService(IHttpProvider httpProvider)
		{
			_httpProvider = httpProvider;
		}

		public async Task<String> getStatus()
		{
			var response = await _httpProvider.GetAsync(Configs.StatusURL);
			var result = response.Content.ReadAsStringAsync().Result;
			return result.ToString();

		}

		public async Task<String> getStatus2()
		{
			var response = await _httpProvider.GetAsync("https://api.temps.com/explorer/status");
			var result = response.Content.ReadAsStringAsync().Result;
			return result.ToString();

		}
	}
}

