using System;
using System.Threading.Tasks;

using RichardSzalay.MockHttp;

using asp.net_core_shceduler_swagger_unittest_.Controllers;
using asp.net_core_shceduler_swagger_unittest_.Services;

namespace tests.Controllers
{
    public class FirstControllerTest
    {
        FirstController firstController;

        public FirstControllerTest()
        {
            HttpProvider httpProvider = new HttpProvider();
            httpProvider.SetMessageHandler(this.createMock());
            firstController = new FirstController(httpProvider);
            //firstController._httpProvider.SetMessageHandler(this.createMock());

        }

        [Fact]
        public void GetName()
        {
            var result = firstController.getName();
            // Assert the result  
            String responseContext = "testing";
            Assert.True(result.Equals(responseContext));


        }

        [Fact]
        public async Task getStatus()
        {
            var response = await firstController.getStatus();
        }

        private MockHttpMessageHandler createMock()
        {
            var mockHttp = new MockHttpMessageHandler();

            // Setup a respond for the user api (including a wildcard in the URL)
            mockHttp.When("https://api.tzstats.com/explorer/status")
                    .Respond("application/json", "{'name' : 'Test McGee'}"); // Respond with JSON

            return mockHttp;
        }
    }
}

