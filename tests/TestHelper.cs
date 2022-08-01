using System;

using RichardSzalay.MockHttp;

using asp.net_core_shceduler_swagger_unittest.Models;
using asp.net_core_shceduler_swagger_unittest.Services;

namespace tests
{
	public static class TestHelper
	{
		public static void setConfigs()
		{
			Configs.TzStatsStatus = "https://api.tzstats.com/explorer/status";
			Configs.TzStatsTickers = "https://api.tzstats.com/markets/tickers";
		}

		public static HttpProvider createMocks(Dictionary<string, string> responseList)
		{
			HttpProvider httpProvider = new HttpProvider();
			var mockHttp = new MockHttpMessageHandler();

			foreach (KeyValuePair<string, string> response in responseList)
			{
				string url = response.Key;
				string responseText = response.Value;

				mockHttp.When(url)
					.Respond("application/json", responseText);

			}

			httpProvider.SetMessageHandler(mockHttp);

			return httpProvider;
		}
	}
}

