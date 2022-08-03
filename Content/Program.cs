using Microsoft.Extensions.DependencyInjection;
using Serilog;

var builder = ConsoleApp.CreateBuilder(args);

builder.UseSerilog();
builder.UseEnvironment(Environment.EnvironmentValue);

builder.ConfigureServices((ctx, services) =>
{
    services.Configure<Settings>(ctx.Configuration.GetSection("Settings"));

    Log.Logger = new LoggerConfiguration()
        .ReadFrom.Configuration(ctx.Configuration)
        .CreateLogger();
});

var app = builder.Build();

app.AddSubCommands<Execution>();

app.RunAsync();
