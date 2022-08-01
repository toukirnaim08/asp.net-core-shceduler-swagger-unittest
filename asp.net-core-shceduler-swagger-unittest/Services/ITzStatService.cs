using System;
namespace asp.net_core_shceduler_swagger_unittest.Services
{
	public interface ITzStatService
	{
		Task<String> get_tickers();
		Task<String> get_staus();
	}
}

