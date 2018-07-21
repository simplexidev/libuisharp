# LibUISharp
[![License](https://img.shields.io/badge/License-MIT-blue.svg?longCache=true)](https://github.com/tom-corwin/LibUISharp/blob/master/LICENSE.md)
[![Build status](https://ci.appveyor.com/api/projects/status/o2y9fu126dqmi4pv?svg=true)](https://ci.appveyor.com/project/tom-corwin/libuisharp)
[![CodeFactor](https://www.codefactor.io/repository/github/tom-corwin/libuisharp/badge)](https://www.codefactor.io/repository/github/tom-corwin/libuisharp)
![NuGet](https://img.shields.io/nuget/vpre/LibUISharp.svg)

LibUISharp is a library containing bindings for [libui](https://github.com/andlabs/libui). Currently, LibUISharp is only built as a .NET Standard 2.0 library, but can also support other frameworks as-per community interest.

**Please Note**: [libui](https://github.com/andlabs/libui) is *mid-alpha* software, meaning the underlying API in LibUISharp is a work-in-progress. Any LibUISharp releases up until v0.4.0 are CI builds, and are not guaranteed to work.

## Looking for Contributors!
Currently, I don't have the free time to make LibUISharp complete on my own. Because of this, I am looking for help from the community. Whether an issue, or a new feature, nothing is to small.

## Features

LibUISharp allows you to create native, cross-platform graphical user interface (GUI) applications containing various controls, such as a `Button` or a `TabControl`, laid out in containers, such as a `GroupContainer`, or a `StackContainer`.

Check out the demos in the `demos\` folder for examples.

## Supported Platforms

LibUISharp supports 64-bit Windows, macOS (with lmited testing), and Linux (tested with Debian-based systems):

| Operating System                                     | Version                                           | Prerequiusites |
| :--------------------------------------------------- | :------------------------------------------------ | :------------- |
| Windows Client<br/>Windows Server                    | 7 SP1+, 8.1, 10 Build 1607+<br/>2008 R2 SP1+      |                |
| Mac OS X                                             | 10.12+                                            |                |
| Debian<br/>Ubuntu</br>Linux Mint                     | 8.7+, 9<br/>14.04, 16.04, 17.10, 18.04<br/>17, 18 | GTK+ 3.10+     |

## Obtaining the Library

LibUISharp is almost up-to-par with libui and is now available on NuGet!

Just add this line to you `csproj` project file:

```
<PackageReference Include="LibUISharp" Version="0.4.0-build-*" />
```

## Building From Source

LibUISharp is built with .NET Core 2.1, so you can build LibUISharp with either Visual Studio, Visual Studio Code,
or just by running a couple simple commands. Use the steps below to get started!

### Prerequisites

| Operating System | Prerequisites                                                                                                            |
| :--------------- | :----------------------------------------------------------------------------------------------------------------------- |
| Windows 7/8.1/10 | .NET Core 2.1 SDK<br/><br/>**Optional:**<br/>Visual Studio 2017 (v15.7.x)<br/>Visual Studio Code (With the C# extension) |
| Mac OS X         | .NET Core 2.1 SDK<br/><br/>**Optional:**<br/>Visual Studio Code (With the C# extension)                                  |
| Linux            | .NET Core 2.1 SDK<br/><br/>**Optional:**<br/>Visual Studio Code (With the C# extension)                                  |

### Build Using Visual Studio (Windows)

*Ensure you have the latest version of Visual Studio 2017 installed with the .NET Core workload.*

1. Open the `LibUISharp.sln` file.
2. Then, navigate to the `Build>Build Solution` menu item.

### Build Using a CLI

Run the following command in a command-line interface in the root directory of this repository:

1. `dotnet build LibUISharp.sln'

## Contributing

Contributing is as easy as filing an issue, fixing a bug, or suggesting a new feature.

Although the document is a work in progress, please see the [CONTRIBUTING.md](https://github.com/tom-corwin/LibUISharp/blob/master/CONTRIBUTING.md) file for more information on contributing.
