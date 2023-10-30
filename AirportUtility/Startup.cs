using AirportUtility.Business;
using AirportUtility.Contract.IBusiness;
using AirportUtility.Contract.IData;
using AirportUtility.Data;
using AirportUtility.Middleware;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
namespace AirportUtility
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSwaggerGen();

            // Inject Dependencies
            services.AddScoped<IAirportManager, AirportManager>();
            services.AddScoped<IAirportData, AirportData>();
        }

        public void Configure(IApplicationBuilder app)
        {
           
            app.UseSwagger();
            app.UseSwaggerUI();

            app.UseMiddleware<RequestResponseLoggingMiddleware>();
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
