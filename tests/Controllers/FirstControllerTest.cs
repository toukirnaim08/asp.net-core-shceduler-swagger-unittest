using System;
using System.Threading.Tasks;

using RichardSzalay.MockHttp;

using tests;
using tests.MockService;

using asp.net_core_shceduler_swagger_unittest_.Controllers;
using asp.net_core_shceduler_swagger_unittest_.Services;
using asp.net_core_shceduler_swagger_unittest_.Models;

namespace tests.Controllers
{
    public class FirstControllerTest
    {
        FirstController firstController;

        public FirstControllerTest()
        {
            TestHelper.setConfigs();
            MockStatusService statusService = new MockStatusService();
            firstController = new FirstController(statusService.getService());
        }

        //[Fact]
        //public void GetName()
        //{
        //    var result = firstController.getName();
        //    // Assert the result  
        //    String responseContext = "testing";
        //    Assert.True(result.Equals(responseContext));
        //}

        [Fact]
        public async Task getStatus2()
        {
            var response = await firstController.getStatus2();
        }

        [Fact]
        public async Task getStatus()
        {
            var response = await firstController.getStatus();
        }
    }
}

