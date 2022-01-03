namespace Cnsola;

public static class Environment
{
    internal const string EnvironmentVariable = "DOTNET_ENVIRONMENT";
    internal static string EnvironmentValue => System.Environment.GetEnvironmentVariable(EnvironmentVariable);
}
