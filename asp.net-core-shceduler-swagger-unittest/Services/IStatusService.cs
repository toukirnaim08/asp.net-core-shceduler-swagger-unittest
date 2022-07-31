using System;
namespace asp.net_core_shceduler_swagger_unittest_.Services
{
	public interface IStatusService
	{
		Task<String> getStatus2();
		Task<String> getStatus();
	}
}

