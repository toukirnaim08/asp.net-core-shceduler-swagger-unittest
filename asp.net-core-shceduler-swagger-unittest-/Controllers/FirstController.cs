using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Net.Http;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using asp.net_core_shceduler_swagger_unittest_.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace asp.net_core_shceduler_swagger_unittest_.Controllers
{
	[Route("[controller]/[action]")]
	public class FirstController : Controller
	{
        IHttpProvider _httpProvider;

        public FirstController(IHttpProvider httpProvider)
		{
            _httpProvider = httpProvider;
        }

        // GET: api/values
        [HttpGet]
		public String getName()
		{
            return "testing";
		}

        [HttpGet]
        public async Task<String> getStatus()
        {
            var response = await _httpProvider.GetAsync("https://api.tzstats.com/explorer/status");
            var result = response.Content.ReadAsStringAsync().Result;
            return result.ToString();

        }
    }
}

