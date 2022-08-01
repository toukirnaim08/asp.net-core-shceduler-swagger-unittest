using System;

using asp.net_core_shceduler_swagger_unittest.Controllers;

namespace tests.Controllers
{
	public class SecondControllerTest
	{
        SecondController secondController;

        public SecondControllerTest()
		{
            secondController = new SecondController();
        }

        [Fact]
        public void get_name()
        {
            var response = secondController.get_name();
        }
    }
}

