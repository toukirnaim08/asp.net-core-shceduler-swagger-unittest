using System;
using Microsoft.EntityFrameworkCore;

using asp.net_core_shceduler_swagger_unittest.Models;

namespace asp.net_core_shceduler_swagger_unittest.Data
{
	public class ExtendedDbContext : DbContext
	{
		public ExtendedDbContext(DbContextOptions<ExtendedDbContext> options) : base(options)
		{

		}
		public DbSet<Result> Result { get; set; }
	}
}

