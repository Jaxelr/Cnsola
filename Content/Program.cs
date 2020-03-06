using System;
using McMaster.Extensions.CommandLineUtils;
using Microsoft.Extensions.Configuration;

namespace Consola
{
    internal class Program
    {
        private static IConfiguration configuration { get; set; }
        private static Settings Settings { get; set; }

        private static void Main(string[] args)
        {
            configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            //Extract the Settings info from the appsettings config.
            Settings = new Settings();
            configuration.GetSection(nameof(Settings)).Bind(Settings);

            CommandLineApplication.Execute<Program>(args);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Code Quality", "IDE0051:Remove unused private members", Justification = "Private member is invoked from .Execute<Program>")]
        private void OnExecute()
        {
            Console.WriteLine("Hello world!");
            Console.WriteLine($"{Settings.Example}");

            if (System.Diagnostics.Debugger.IsAttached)
                Console.Read();
        }
    }
}
