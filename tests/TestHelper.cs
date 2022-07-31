using System;

using RichardSzalay.MockHttp;

using asp.net_core_shceduler_swagger_unittest_.Models;
using asp.net_core_shceduler_swagger_unittest_.Services;

namespace tests
{
	public static class TestHelper
	{
		public static void setConfigs()
		{
			Configs.StatusURL = "https://api.tzstats.com/explorer/status";
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

