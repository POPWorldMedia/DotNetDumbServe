using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace DotNetDumbServe
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddResponseCompression();
			services.AddResponseCaching();
		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			app.UseResponseCompression();
			app.UseResponseCaching();
			app.UseStaticFiles();
		}
	}
}