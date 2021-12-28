using System.Threading.Tasks;
using ConsoleAppFramework;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace Cnsola
{
    internal static class Program
    {
        internal const string EnvironmentVariable = "ASPNETCORE_ENVIRONMENT";
        internal static string Environment => System.Environment.GetEnvironmentVariable(EnvironmentVariable);

        internal static async Task Main(string[] args) =>

            await Host.CreateDefaultBuilder()
                .UseEnvironment(Environment)
                .UseSerilog()
                .ConfigureServices((hostContext, services) =>
                {
                    services.Configure<Settings>(hostContext.Configuration.GetSection("Settings"));

                    Log.Logger = new LoggerConfiguration()
                        .ReadFrom.Configuration(hostContext.Configuration)
                        .CreateLogger();
                })
                .RunConsoleAppFrameworkAsync<Cnsola>(args);
    }
}
