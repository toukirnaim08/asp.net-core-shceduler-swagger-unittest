using System;
using System.Threading.Tasks;

using RichardSzalay.MockHttp;

using tests;
using tests.MockService;

using asp.net_core_shceduler_swagger_unittest.Controllers;

namespace tests.Controllers
{
    public class FirstControllerTest
    {
        FirstController firstController;

        public FirstControllerTest()
        {
            TestHelper.setConfigs();
            MockTzStatsService tzStatsService = new MockTzStatsService();
            firstController = new FirstController(tzStatsService.getService());
        }

        [Fact]
        public async Task get_tickers()
        {
            var response = await firstController.get_tickers();
        }

        [Fact]
        public async Task get_staus()
        {
            var response = await firstController.get_staus();
        }
    }
}

