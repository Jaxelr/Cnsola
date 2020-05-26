using System;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Configuration;
using Serilog;

namespace Cnsola
{
    internal class Program
    {
        internal const string EnvironmentVariable = "ASPNETCORE_ENVIRONMENT";

        private static IConfiguration configuration { get; set; }
        private static Settings Settings { get; set; }
        private static string env => Environment.GetEnvironmentVariable(EnvironmentVariable);

        internal static void Main(string[] args)
        {
            Log.Logger = new LoggerConfiguration()
                                .MinimumLevel.Information()
                                .Enrich.FromLogContext()
                                .WriteTo.Console()
                                .CreateLogger();

            configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .AddJsonFile($"appsettings{env}.json", true, true)
                .Build();

            //Extract the Settings info from the appsettings config.
            Settings = new Settings();
            configuration.GetSection(nameof(Settings)).Bind(Settings);

            CommandLineApplication.Execute<Program>(args);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Code Quality", "IDE0051:Remove unused private members", Justification = "Private member is invoked from .Execute<Program>")]
        private void OnExecute()
        {
            try
            {
                Log.Logger.Information($"Environment used: {env}");
                Log.Logger.Information("Hello world!");
                Log.Logger.Information($"{Settings.Example}");

                if (System.Diagnostics.Debugger.IsAttached)
                    Console.Read();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message);
                Environment.Exit(1);
            }
        }
    }
}
