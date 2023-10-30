using AirportUtility;
using Serilog;

public class Program
{
    public static void Main(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json") // Load your appsettings.json file
            .Build();

        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(configuration) // Read Serilog settings from the configuration
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

