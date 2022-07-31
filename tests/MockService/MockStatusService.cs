using asp.net_core_shceduler_swagger_unittest.Models;
using asp.net_core_shceduler_swagger_unittest.Services;

namespace tests.MockService
{
	public class MockStatusService
	{
		Dictionary<string, string> responseList = new Dictionary<string, string>(2);

		public MockStatusService()
		{
			responseList.Add(Configs.StatusURL, "temp1");
			responseList.Add("https://api.temps.com/explorer/status", "temp2");
		}

		public StatusService getService()
		{
			HttpProvider httpProvider = TestHelper.createMocks(responseList);
			return new StatusService(httpProvider);

		}
	}
}

