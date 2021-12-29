# Cnsola [![Mit License][mit-img]][mit]

Minimal dotnet template library for console utilities. 

## Builds

| Appveyor  | Github |
| :---:     | :---: |
| [![Build status][build-img]][build] | ![.NET](https://github.com/Jaxelr/Cnsola/workflows/.NET/badge.svg?branch=master) |

## Packages

| NuGet (Stable) | Feedz.io (Mirror) | MyGet (Pre-release)
| :---: | :---: | :---: |
| [![NuGet][nuget-img]][nuget] | [![Feedz.io][feedz-img]][feedz] | [![MyGet][myget-img]][myget] |

### Purpose

A scaffolded console application built on top of dotnet. It provides the basic tools for handling of console arguments, logging into multiple destinations and configuration management.

### Installation

For installation via the dotnet install command:

`dotnet new -i "Cnsola::*"`

For the Feedz (mirror) or Myget (pre-release) installations you can specify the source on the dotnet command:

`dotnet new -i "Cnsola::*" --nuget-source https://f.feedz.io/jaxelr/cnsola/nuget/index.json`

Then you can freely create templates by executing the following dotnet command:

`dotnet new cnsola -o MySampleConsole`

### Uninstallation

To uninstall execute:

`dotnet new -u "Cnsola"`

This template targets versions are:

| net version | template version |
| -- | -- |
| 6.0 | latest |
| 5.0 | 0.0.4 |
| 3.1 | 0.0.1 |

The following libraries are included as part of the solution:

* [ConsoleAppFramework](https://github.com/Cysharp/ConsoleAppFramework)
* [Serilog.AspNetCore](https://github.com/serilog/serilog-aspnetcore)

For further information on custom templates, refer to the [Microsoft documentation][docs].

[mit-img]: http://img.shields.io/badge/License-MIT-blue.svg
[mit]: https://github.com/Jaxelr/Cnsola/blob/master/LICENSE
[build-img]: https://ci.appveyor.com/api/projects/status/i6894qg3nyev6cye/branch/master?svg=true
[build]: https://ci.appveyor.com/project/Jaxelr/cnsola/branch/master
[nuget-img]: https://img.shields.io/nuget/v/Cnsola.svg
[nuget]: https://www.nuget.org/packages/Cnsola
[feedz-img]: https://img.shields.io/badge/endpoint.svg?url=https://f.feedz.io/jaxelr/cnsola/shield/Cnsola/stable
[feedz]: https://f.feedz.io/jaxelr/cnsola/packages/Cnsola/stable/download
[docs]: https://docs.microsoft.com/en-us/dotnet/core/tools/custom-templates
[myget-img]: https://img.shields.io/myget/cnsola/v/cnsola.svg
[myget]: https://www.myget.org/feed/cnsola/package/nuget/cnsola
