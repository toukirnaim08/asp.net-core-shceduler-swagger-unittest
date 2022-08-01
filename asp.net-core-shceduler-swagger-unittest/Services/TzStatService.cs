using System;

using asp.net_core_shceduler_swagger_unittest.Models;

namespace asp.net_core_shceduler_swagger_unittest.Services
{
	public class TzStatService : ITzStatService
	{
		IHttpProvider _httpProvider;

		public TzStatService(IHttpProvider httpProvider)
		{
			_httpProvider = httpProvider;
		}

		public async Task<String> get_tickers()
		{
			var response = await _httpProvider.GetAsync(Configs.TzStatsTickers);
			var result = response.Content.ReadAsStringAsync().Result;
			return result.ToString();

		}

		public async Task<String> get_staus()
		{
			var response = await _httpProvider.GetAsync(Configs.TzStatsStatus);
			var result = response.Content.ReadAsStringAsync().Result;
			return result.ToString();

		}
	}
}

