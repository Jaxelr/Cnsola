using System;
using System.Threading.Tasks;
using ConsoleAppFramework;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Serilog;

namespace Cnsola
{
    internal static class Program
    {
        internal const string EnvironmentVariable = "ASPNETCORE_ENVIRONMENT";
        private static string env => Environment.GetEnvironmentVariable(EnvironmentVariable);

        internal async static Task Main(string[] args) =>

            await Host.CreateDefaultBuilder()
                .UseEnvironment(env)
                .UseSerilog()
                .ConfigureServices((hostContext, services) =>
                {
                    services.Configure<Settings>(hostContext.Configuration.GetSection("Settings"));

                    Log.Logger = new LoggerConfiguration()
                        .ReadFrom.Configuration(hostContext.Configuration)
                        .CreateLogger();
                })
                .RunConsoleAppFrameworkAsync<Cnsola>(args);


        public class Cnsola : ConsoleAppBase
        {
            private readonly IOptions<Settings> settings;

            private readonly ILogger<Cnsola> logger;

            public Cnsola(IOptions<Settings> settings, ILogger<Cnsola> logger) => (this.settings, this.logger) = (settings, logger);

            public void Run()
            {
                try
                {
                    logger.LogInformation($"Environment used: {env}");
                    logger.LogInformation("Hello world!");
                    logger.LogInformation($"{settings.Value.Example}");

                    if (System.Diagnostics.Debugger.IsAttached)
                        Console.Read();
                }
                catch (Exception ex)
                {
                    logger.LogError(ex.Message);
                    Environment.Exit(1);
                }
            }
        }
    }
}
