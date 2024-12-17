using Cnsola.Config;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

var builder = Host.CreateDefaultBuilder();

builder.UseSerilog();
builder.UseEnvironment(Environment.EnvironmentValue);

builder.ConfigureServices((ctx, services) =>
{
    services.Configure<Settings>(ctx.Configuration.GetSection("Settings"));

    Log.Logger = new LoggerConfiguration()
        .ReadFrom.Configuration(ctx.Configuration)
        .CreateLogger();
});

using var host  = builder.Build();

ConsoleApp.ServiceProvider = host.Services.CreateScope().ServiceProvider;

var app = ConsoleApp.Create();

app.Add<Execution>();

await app.RunAsync(args);
