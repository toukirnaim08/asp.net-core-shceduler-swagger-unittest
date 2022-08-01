using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using asp.net_core_shceduler_swagger_unittest.Services;
using asp.net_core_shceduler_swagger_unittest.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace asp.net_core_shceduler_swagger_unittest.Controllers
{
	[Route("[controller]/[action]")]
	public class FirstController : Controller
	{
        ITzStatService _tzStatService;

        public FirstController(ITzStatService tzStatService)
		{
            _tzStatService = tzStatService;
        }

        [HttpGet]
        public async Task<String> get_tickers()
        {
            var response = await _tzStatService.get_tickers();

            return response;

        }

        [HttpGet]
        public async Task<String> get_staus()
        {
            var response = await _tzStatService.get_staus();

            return response;

        }
    }
}

