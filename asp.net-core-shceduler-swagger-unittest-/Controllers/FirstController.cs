using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using asp.net_core_shceduler_swagger_unittest_.Services;
using asp.net_core_shceduler_swagger_unittest_.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace asp.net_core_shceduler_swagger_unittest_.Controllers
{
	[Route("[controller]/[action]")]
	public class FirstController : Controller
	{
        IStatusService _statusService;

        public FirstController(IStatusService statusService)
		{
            _statusService = statusService;
        }

        // GET: api/values
        //      [HttpGet]
        //public String getName()
        //{
        //          return "testing";
        //}

        [HttpGet]
        public async Task<String> getStatus2()
        {
            var response = await _statusService.getStatus2();

            return response;

        }

        [HttpGet]
        public async Task<String> getStatus()
        {
            var response = await _statusService.getStatus();

            return response;

        }
    }
}

