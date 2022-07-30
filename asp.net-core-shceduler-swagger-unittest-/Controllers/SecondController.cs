using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace asp.net_core_shceduler_swagger_unittest_.Controllers
{
	[Route("[controller]/[action]")]
	public class SecondController : Controller
	{
		// GET: api/values
		[HttpGet]
		public String getName()
		{
			return "testing";
		}
	}
}

