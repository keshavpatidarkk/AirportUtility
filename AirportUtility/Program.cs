using AirportUtility;
using AirportUtility.Business;
using AirportUtility.Contract.IBusiness;
using AirportUtility.Contract.IData;
using AirportUtility.Data;
using AirportUtility.Middleware;
using Serilog;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        Log.Logger = new LoggerConfiguration()
            .WriteTo.File("log.txt")
            .CreateLogger();

        CreateHostBuilder(args).Build().Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            });
}

//var builder = WebApplication.CreateBuilder(args);


//Log.Logger = new LoggerConfiguration()
//           .WriteTo.File("log.txt")
//           .CreateLogger();

//// Add services to the container.

//builder.Services.AddControllers();
//builder.Services.AddSwaggerGen();

////Inject Dependencies
//builder.Services.AddScoped<IAirportManager, AirportManager>();
//builder.Services.AddScoped<IAirportData, AirportData>();

//var app = builder.Build();

//// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.UseSwagger();
//    app.UseSwaggerUI();
//}

//app.MapControllers();
//app.UseMiddleware<RequestResponseLoggingMiddleware>();
//app.Run();
