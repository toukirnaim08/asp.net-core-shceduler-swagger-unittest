using asp.net_core_shceduler_swagger_unittest.Models;
using asp.net_core_shceduler_swagger_unittest.Services;

namespace tests.MockService
{
	public class MockTzStatsService
	{
		Dictionary<string, string> responseList = new Dictionary<string, string>(2);

		public MockTzStatsService()
		{
			responseList.Add(Configs.TzStatsTickers, "temp1");
			responseList.Add(Configs.TzStatsStatus, "temp1");
		}

		public TzStatService getService()
		{
			HttpProvider httpProvider = TestHelper.createMocks(responseList);
			return new TzStatService(httpProvider);
		}
	}
}

