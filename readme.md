# Consola [![Mit License][mit-img]][mit]

Dotnet template library used for console applications.

## Builds

| Appveyor  |
| :---:     |
| [![Build status][build-img]][build] |

## Packages

| NuGet (Stable) | Feedz (Prerelease) |
| :---: | :---: |
| [![NuGet][nuget-img]][nuget] | [![Feedz][feedz-img]][feedz] |

### Purpose

A scaffolded console application built on top of netcore 3.1. It provides the basic tools for managing console arguments, logging and configuration management.

### Install

For installation via the dotnet install command:

`dotnet new -i "Consola::*"`

For the Feedz installations you can specify the source on the dotnet command:

`dotnet new -i "Consola::*" --nuget-source https://f.feedz.io/jaxelr/consola/nuget/index.json`

Then you can freely use it by executing the following dotnet command:

`dotnet new consola -o MySampleConsole`

### Uninstall

To uninstall simply execute:

`dotnet new -u "Consola"`

These projects target dotnet core 3.1. The following libraries are included as part of the projects:

* [McMaster.Extensions.CommandLineUtils](https://github.com/natemcmaster/CommandLineUtils)
* [Serilog.AspNetCore](https://github.com/serilog/serilog-aspnetcore)

For further information on custom templates, refer to the [Microsoft documentation][docs].

[mit-img]: http://img.shields.io/badge/License-MIT-blue.svg
[mit]: https://github.com/Jaxelr/Consola/blob/master/LICENSE
[build-img]: https://ci.appveyor.com/api/projects/status/4q831j12p00mkeij/branch/master?svg=true
[build]: https://ci.appveyor.com/project/Jaxelr/consola/branch/master
[nuget-img]: https://img.shields.io/nuget/v/Consola.svg
[nuget]: https://www.nuget.org/packages/Consola/
[feedz-img]: https://img.shields.io/badge/endpoint.svg?url=https://f.feedz.io/jaxelr/consola/shield/Consola/stable
[feedz]: https://f.feedz.io/jaxelr/consola/packages/Consola/stable/download
[docs]: https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates
