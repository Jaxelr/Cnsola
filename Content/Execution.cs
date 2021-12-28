using System;
using ConsoleAppFramework;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Cnsola
{
    public class Cnsola : ConsoleAppBase
    {
        private readonly IOptions<Settings> settings;

        private readonly ILogger<Cnsola> logger;

        public Cnsola(IOptions<Settings> settings, ILogger<Cnsola> logger) => (this.settings, this.logger) = (settings, logger);

        public void Run()
        {
            try
            {
                logger.LogInformation("Environment used: {0}", Program.Environment);
                logger.LogInformation("Hello world!");
                logger.LogInformation("{0}", settings.Value.Example);

                if (System.Diagnostics.Debugger.IsAttached)
                    Console.Read();
            }
            catch (Exception ex)
            {
                logger.LogError(ex, "Error executing Cnsola.exe");
            }
        }
    }
}
