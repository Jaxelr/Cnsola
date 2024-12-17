using Cnsola.Config;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Cnsola;

public class Execution
{
    private readonly IOptions<Settings> settings;

    private readonly ILogger<Execution> logger;

    public Execution(IOptions<Settings> settings, ILogger<Execution> logger) => (this.settings, this.logger) = (settings, logger);

    [Command("")]
    public void Run()
    {
        try
        {
            logger.LogInformation("Environment used: {EnvironmentValue}", Environment.EnvironmentValue);
            logger.LogInformation("Hello world!");
            logger.LogInformation("{Example}", settings.Value.Example);

            if (System.Diagnostics.Debugger.IsAttached)
                System.Console.Read();
        }
        catch (System.Exception ex)
        {
            logger.LogError(ex, "Error executing Cnsola.exe");
        }
    }
}
