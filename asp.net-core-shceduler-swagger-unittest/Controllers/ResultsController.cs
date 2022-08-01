using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using asp.net_core_shceduler_swagger_unittest.Data;
using asp.net_core_shceduler_swagger_unittest.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace asp.net_core_shceduler_swagger_unittest.Controllers
{
	[Route("[controller]/[action]")]
	public class ResultsController : Controller
	{
		private readonly ExtendedDbContext _extendedDbContext;

		public ResultsController(ExtendedDbContext extendedDbContext)
		{
			_extendedDbContext = extendedDbContext;
		}

		// GET: api/values
		[HttpGet]
		public async Task<string> get_all()
		{
			var results = await _extendedDbContext.Result.ToListAsync();
			return "ok";
		}

		[HttpPost]
		public async Task<string> create(Result rt)
		{
			_extendedDbContext.Add(rt);
			await _extendedDbContext.SaveChangesAsync();
			return "ok";
		}
	}
}

