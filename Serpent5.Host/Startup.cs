using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Serpent5.Host
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection serviceCollection)
        {
            serviceCollection.AddRazorPages();

            serviceCollection.Configure<RouteOptions>(o => o.LowercaseUrls = true);
        }

        public void Configure(IApplicationBuilder applicationBuilder, IHostEnvironment hostEnvironment)
        {
            if (hostEnvironment.IsDevelopment())
                applicationBuilder.UseDeveloperExceptionPage();
            else
                applicationBuilder.UseExceptionHandler();

            applicationBuilder.UseHttpsRedirection();

            applicationBuilder.UseRouting();
            applicationBuilder.UseEndpoints(endpointRouteBuilder =>
            {
                endpointRouteBuilder.MapRazorPages();
            });
        }
    }
}
