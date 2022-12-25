﻿# XPNet

Develop [X-Plane](http://www.x-plane.com/) plugins in .NET.

<p align="center">
    <a href="https://www.nuget.org/packages/XPNet.CLR.Template/" alt="NuGet">
        <img src="https://buildstats.info/nuget/XPNet.CLR.Template" />
    </a>
</p>

:email: Follow [XPNetSim](http://twitter.com/xpnetsim) on Twitter for release notifications and news.

## What Is This?

XPNet is an API binding for writing plugins in C# or other .NET languages for the X-Plane
flight simulator.

The design goals for XPNet are:

1. Provide excellent performance: it should be possible to write plugins in C# that don't kill your framerate.
2. Provide an idiomatic .NET programming environment: that means classes, events and properties, where doing so does not conflict too badly with #1.
3. Don't stray too far from X-Plane core concepts: meaning #2 only goes so far, so the X-Plane API documentation is a decent guide to the concepts needed to write a plugin for X-Plane in C#.
4. Be cross-platform: X-Plane works on Windows, macOS and Linux, so your plugins should too.

XPNet is an attempt to create a .NET plugin environment for X-Plane that strikes a reasonable
balance between those sometimes-conflicting goals.  With some exceptions, where the library provides
a higher-level abstraction above X-Plane, you only pay for that abstraction if you choose to use it.

To accomplish the goal of being cross-platform, XPNet is based on
[.NET Core](https://github.com/dotnet/core).  If you're familiar with .NET but unfamiliar
with .NET Core, it is essentially the result of Microsoft open-sourcing the .NET
base libraries, runtime and compilers.  It runs on Windows, Linux and macOS.  The core things
you expect from a .NET environment are there: String and Stream and List<T>, but it
works on more than just Windows, and some of the "rough edges" of the base class library
have been cleaned up.

An XPNet plugin consists of three parts:

1. A native .DLL/.SO, compiled for each OS and architecture, which is what X-Plane sees and loads as a plugin.  The native wrapper creates a CLR runtime inside of X-Plane and runs the plugin inside it.  XPNet provides this piece.
2. A .NET API layer, which implements the XPNet API on top of the X-Plane API.  XPNet provides this piece.
3. A .NET class that implements IXPlanePlugin and provides your plugin logic.  You provide this piece.


## Writing a Plugin Class

A plugin class must meet three requirements.

1. Implement the XPNet.IXPlanePlugin interface.
2. Add the XPlanePlugin attribute to the class.
3. Create a public constructor on the class that accepts one parameter of type IXPlaneApi.

You should read the docs for writing plugins in X-Plane.  The core concepts are the same.

* [X-Plane API Docs](https://developer.x-plane.com/sdk/)
* Your plugin's constructor corresponds to XPluginStart.
* Your plugin's Dispose method corresponds to XPluginStop.
* IXPlanePlugin.Enable() corresponds to XPluginEnable.
* IXPlanePlugin.Disable() corresponds to XPluginDisable.

During your development, you'll have to be sure that you stay within the confines of
what is available on .NET Core.  Describing exactly what that means is beyond the scope
of this document.  .NET Core is a full-featured CLR runtime, not a "stripped-down" version
of .NET, but it _does_ have some differences from the traditional .NET Framework.

Additionally, if you really only care if your plugin works on Windows, you could make
some modifications to the build dependencies and build against the .NET Framework instead
of .NET Core.  Contributions that provide such a build path will be (carefully) considered,
if they do not get in the way of the default being cross-platform, .NET Core-based development.
You'll have to require the appropriate version of the .NET Framework to be installed on the
computer running X-Plane if you do that.

Here's a minimal plugin class.  See the LoggerPlugin example in the source
code for a more interesting example.

```C#
    using XPNet;

    [XPlanePlugin(
        name: "Goodbye World",
        signature: "qb.plugins.goodbyeWorld",
        description: "The obligatory Hello, World example."
    )]
    public class GoodbyeWorldPlugin : IXPlanePlugin
    {
        private readonly IXPlaneApi m_api;

        public GoodbyeWorldPlugin(IXPlaneApi api)
        {
            m_api = api ?? throw new ArgumentNullException("api");

            m_api.Messages.PlaneCrashed += OnPlaneCrashed;
        }

        public void Dispose()
        {
            // Clean up whatever we attached / registered for / etc.

            m_api.Messages.PlaneCrashed -= OnPlaneCrashed;
        }

        private void OnPlaneCrashed(object sender, XPMessageEventArgs e)
        {
            m_api.Log.Log("On noes!  Goodbye cruel world!");
        }

        public void Enable()
        {
            // Nothing to do b/c we don't have any interesting work going on.
        }

        public void Disable()
        {
            // Nothing to do b/c we don't have any interesting work going on.
        }
    }
```


## TODOs

XPNet currently runs on Windows and macOS and exposes the following subsystems of the X-Plane API:

- [x] Reading and writing DataRefs (data fields provided by X-Plane or other plugins)
- [x] Processing (plugging into the X-Plane processing loop to do periodic processing)
- [x] 2017-12-22 - Invoking Commands (XPLMCommandBegin/End/Once)

XPNet is a new project and there are a ton of ways it could be improved.  At present, you
can use XPNet to develop a plugin that reads and writes DataRefs and does
scheduled background processing (such as communicating on a network or serial port).

With the help of contributors, I'd like to see XPNet grow in at least the following ways:

- [ ] Expand to Linux.  (We already run on macOS, so we're most of the way to Linux, for someone with good C/C++ and relevant platform experience.)
- [ ] Automatically find the plugin to load in simple cases based on naming convention rather than requiring a config entry.  I tried to do this from the start but it appears that System.Reflection.Metadata is just fundamentally broken in .NET Core, and things like Cecil don't work on Core (at least not in the effort I'm willing to put into it).  When the Core tooling gets better, or someone wants to contribute who can provide a solution, revisit this.
- [ ] Support the newer AOT native compilation features of .NET to allow building plugins that are already fully compiled for each platform.
- [x] Build out the Fluent Data API.  What we have so far is more a concept than anything.  Possibly this is a template/tool that creates the Fluent API from the DataRefs.txt that comes with X-Plane, instead of building the thing by hand.
- [x] 2018-12-15 - Extend the test harness to be more generally useful for other plugins beyond the sample Logging plugin.
- [x] 2018-11-27 - Improve the native output directory structure for the C++ VS 2017 projects - by default, for backwards compatibility, MS makes project outputs inconsistent between x86 and x64 builds.  It all works...but is unnecessarily confusing.
- [x] 2018-07-25 - Publish a nuget package to make it easy to create a plugin.  The package should ideally be "fat", including binaries for Windows, macOS and Linux in appropriate arch subdirectories, so that you can easily create plugin projects that reference XPNet and which you can then just xcopy-deploy into X-Plane.
- [x] 2018-02-25 - Expand to macOS.
- [x] 2018-07-25 - Implement tooling or procedures to make it easier to create a plugin and get it installed or distributed.  ('dotnet new' template)
- [x] 2017-09-08 - Automatically detect and use any compatible .NET Core install found in <Plugin-Path>/64/dotnet (or <Plugin-Path>/32/dotnet) instead of assuming release 1.1.1.

Additionally, the following aspects of the X-Plane API need mappings to XPNet.

- [ ] Registering custom DataRefs (to expose to other plugins).
- [ ] XPLMCamera
- [ ] XPLMDisplay
- [ ] XPLMGraphics
- [ ] XPLMInstance
- [ ] XPLMMap
- [ ] XPLMMenus
- [ ] XPLMNavigation
- [ ] XPLMPlanes
- [ ] XPLMScenery
- [ ] XPLMUtilities
- [ ] Widgets (XPLMWidgets / XPLMWidgetDefs / XPLMWidgetUtils / XPLMStandardWidgets)
- [ ] XPUIGraphics
- [ ] XPLM Feature Keys


## Developing a Plugin

You can develop plugins on Windows or MacOS, using Visual Studio 2017 Community, Visual Studio Code, or
other editing tools, with the .NET Core SDK 2.1 or higher.  All of the tools mentioned above are
free [(as in beer)](https://en.wikipedia.org/wiki/Gratis_versus_libre)
downloads from Microsoft, and .NET Core and Visual Studio Code are open source.

(You should be able to develop a plugin on Linux as well, using the same tools,
but I haven't tried it.  See the TODO list, above, regarding officially adding Linux support.)

1. Start a new .NET Core Class Library project.
2. Either install the XPNet nuget packages, or download and build XPNet and reference XPNet.CLR.dll it from your project.
3. Create a plugin class and develop your plugin.  See below for more details.
4. Deploy into X-Plane.  See below for more details.

The recommended way to start a new project is to use the "dotnet new" command with the
XPNet project template and use the pre-built nuget binaries.  Even if you want to work in
Visual Studio, starting from the project template at the command line will give you a
starting point with the correct nuget packages and a plugin class to start with.

### Starting a New Project with `dotnet new`

If you don't know which option you want, you probably want this option.  You'll need the
.NET SDK v2.1 or higher installed.  These instructions work for Windows and macOS.

Step Zero - One Time - Get the dotnet-install tool installed.

We hope to make this step unnecessary in the future by including that command as a project
dependency so that it gets installed automatically when needed.  If you skip this step, your
project will build but fail to publish correctly later.  
```
dotnet tool install -g QB.DotNetCoreInstaller
```
After installing this tool, type `dotnet install -h` at your command prompt and see
if you get useful help; if not, you may have to close and reopen your terminal/console
window (or restart your computer in the worst case).

Once you can type `dotnet install -h` and get the help page rather than "command not found",
you are ready to proceed.


1. Create a directory for your new project.

2. Install or update the 'dotnet new' template for XPNet.
```
dotnet new -i XPNet.CLR.Template
```


3. Create a new plugin project.
```
dotnet new xpnetplugin -n <Your-Plugin-Name>
```

That will leave you with a new project (a .csproj file) and a single C# code file with a
empty plugin class that writes to the log.  You can build and install this plugin immediately
and run X-Plane to verify that the plugin is working, by looking for its output in the
file _xpnet.log_ in the plugin directory.

Happy coding!

### Building and Deploying to X-Plane for Debug

When you're ready to build and run your plugin, run the following command from the
directory that contains your .csproj file.

```
dotnet publish -c Debug -o "<Path-To-X-Plane>/Resources/plugins/<Your-Plugin-Name>"
```

Then just start up X-Plane.  If everything has gone as expected, your plugin should
load.

### Building for Debug Without Deploying

If you want to make a local build without immediately copying+deploying into
a local X-Plane install, just leave off the -o parameter and its argument.
That will build your plugin and place it in a directory on disk like so:

> YourProjectRoot/bin/Debug/netcoreapp2.1/publish

The exact location will vary depending on which version of .NET Core you are
targetting, your release configuration, etc.  To deploy to X-Plane, either
run `dotnet publish` with the -o parameter as shown above, or manually copy the
contents of your publish directory into a new plugin folder in X-Plane.

### Building for Distribution

To build in Release mode for distribution, just specify Release configuration
and look in the corresponding Release directory on disk for the output.

```
dotnet publish -c Release
```

The `dotnet publish` command for an XPNet plugin automatically installs
runtimes for all platforms that are currently supported, so you end up
with a build output that you could copy to any machine on any platform;
it should _just work_.  You can configure which runtimes are installed
by editing the `InstallNetCoreShared` section of the .csproj for your plugin.


### Creating a Project Manually with Visual Studio

If you're intent on rolling your own instead of using the starter project, or if you want to
build XPNet yourself instead of using the prebuilt nuget packages, you can start a
project from Visual Studio and set it all up manually.  Some pointers for doing it this way:

1. When creating your plugin project, start a new "Class Library (.NET Core)" project.  (You want ".NET Core", not ".NET Standard".  Look under "Templates -> Visual C# -> .NET Core").
2. If you're using the nuget packages instead of building XPNet yourself, the packages to get are `XPNet.CLR`, `XPNet.Native.macOS` and `XPNet.Native.Windows`.  You want _all_ the native packages, not just the ones for the platform you're buliding on, or your plugin won't be able to work on any platform other than the one you developed it on.
3. See the section `Installing into X-Plane` below for details about manually installing into X-Plane.


## Installing into X-Plane

**__You only need to do this if you are not using the starter project.  See above.__**

Installing into X-Plane involves copying various files into the correct place in
an X-Plane install.  You must build or obtain either or both 32-bit and 64-bit
builds of the following:

* [.NET Core](https://www.microsoft.com/net/download/core)
* XPNet Build Outputs (XPNet.Native.dll, XPNet.CLR.dll, and nuget dependencies like Newtonsoft.Json).
* Your built plugin DLL and its dependencies (if any).

For .NET Core, you want the binaries (.zip file), not the installer,
because you'll unzip and copy the .NET Core install into the correct location.

XPNet currently assumes that it will be running against .NET Core 2.1 or above.

As with all other X-Plane plugins, you install an XPNet-based
plugin by copying the necessary files into your X-Plane install at 

> _X-Plane-Directory_/Resources/Plugins/_Your-Plugin-Directory_

You create a directory that matches the name of your plugin.  So let's assume
that X-Plane is installed at _D:\X-Plane 11_ and we want to install the
XPNet.LoggerPlugin that comes with XPNet.  On disk, we'll have a directory
structure like this:


```
D:\X-Plane 11\Resources\plugins\
|
└───XPNet.Logger\                      <-- Directory containing your plugin.  Give it some appropriate name.
    |
    └───XPNet.CLR.dll
    └───XPNet.LoggerPlugin.dll         <-- Your plugin DLL.
    └───xpnetcfg.json                  <-- The XPNet Configuration File
    └───Microsoft.Extensions.*.dll     <-- These and other DLLs that are required dependencies of XPNet.
    |
    └─── dotnet-windows\               <-- Unzip dotnet-win-x64.2.x.x.zip here.
    |    └───host\
    |    └───shared\
    |    └───etc.
    |
    └─── dotnet-macos\                 <-- Same as Windows version above, but mac hosting.
    |    └───host,shared,etc.
    |
    └───32\                            <-- Same as 64 below, but with 32-bit binaries.
    |
    └───64\
        |
        └───win.xpl                    <-- Output of XPNet.Native project built for Windows.
        └───mac.xpl                    <-- Output of XPNet.Native project built for macOS.
```

From X-Plane's standpoint, the actual plugin is a DLL or SO that is
named win.xpl, lin.xpl or mac.xpl.  XPNet provides this library via
a native "shim" project called XPNet.Native.

## Configuring XPNet

To get XPNet to load your plugin, you give it a configuration file, _xpnetcfg.json_.
Here is an example configuration file that tells XPNet to load the XPNet.LoggerPlugin
example plugin.  Replace the assembly name and class name here with your own info to
get XPNet to load your own plugin.

```JSON
{
  "PluginAssemblyName": "XPNet.LoggerPlugin.dll",
  "PluginType": "XPNet.LoggerPlugin",
  "LoggingEnabled": false
}
```

## Logging

On initial startup, XPNet writes into the X-Plane log (_Log.txt_).  Look in that
log for information about whether the plugin can load in the first place.  If
X-Plane is unable to load the XPNet plugin, or if the XPNet plugin is unable to
initialize the .NET runtime, then error messages about that will appear in the
X-Plane _Log.txt_.

Once XPNet gets going, it provides a separate logging mechanism that can be turned on and
off by setting the LoggingEnabled property in the _xpnetcfg.json_ configuration file.  Extensive logging can be a significant
performance hit, so it is recommended that you use logging to test your plugin but deliver
the plugin to users with logging turned off, and provide instructions
to end-users for how to turn logging on if it is necessary to find a solution to a problem.

When enabled, the log file is written in UTF-8 encoding to the file _xpnet.log_ in the plugin
directory.

## The XPNet.LoggerPlugin Example

XPNet includes a sample plugin which logs the output of DataRefs.  You configure which
DataRefs to log via the _xpnetcfg.json_ configuration file.  Here is an example config
file which logs various types of DataRefs.

```JSON
{
  "PluginAssemblyName": "XPNet.LoggerPlugin.dll",
  "PluginType": "XPNet.LoggerPlugin",
  "LoggingEnabled": true,
  "XPNetLogger": {
    "StringData": [ 
      "sim/aircraft/view/acf_tailnum",
    ],
    "IntData": [ 
      "sim/aircraft/electrical/num_buses",
    ],
    "BoolArrayData": [ 
      "sim/cockpit/engine/fadec_on",
    ],
    "FloatData": [ 
      "sim/cockpit/electrical/instrument_brightness",
    ],
    "BoolData": [ 
      "sim/cockpit/engine/inverter_eq",
    ]
  }
}
```


## Async / Threading

XPNet supports but does not provide particular facilities for asynchronous / threaded operations.

XPNet does not provide any threading capabilities on its own.  Unless otherwise specified,
all events and methods are raised or called on X-Plane's user interface thread.  Additionally,
again unless otherwise specified, XPNet is not internally threadsafe.  This helps keep the
library performant, and frankly many scenarios don't need any asynchronous behavior.

If your scenario does need threaded or asynchronous behavior, however, by all means kick off
what you need to.  The rule is: if you're calling back to X-Plane or XPNet, including reading
DataRefs or writing to the log, make that call on the thread that your plugin was constructed on.

You should consider using constructs like the async/await keywords in C#, rather than directly
working with Threads.  Threaded operation is beyond the scope of this documentation, but it is
not discouraged for those who know what they're doing.  Contributions that provide high-level
(but performant) Task- or queue-based asynchronous capabilities that work well in the X-Plane
environment (i.e., that make it easy to do asynchronous operations in a plugin) would be welcomed.


## Building XPNet

```
You don't need to build XPNet if all you want to do is create your own plugin,
because there are prebuilt binaries available via nuget.  See the instructions above
in the `Developing a Plugin` section.

These instructions are for if you want to contribute to or modify XPNet itself.
```

XPNet consists of three parts:

1. A native shim (XPNet.Native)
2. The core XPNet .NET DLL (XPNet.CLR), along with several dependent DLLs.
3. Your code, packaged as a .NET DLL.

The native shim has to be named win.xpl, lin.xpl or mac.xpl, depending on the platform,
and dropped into a plugin folder alongside the other DLLs and config files as described
in "Installing Into X-Plane" above.

```
Starting with X-Plane 11.10, X-Plane allows a new optional naming convention for plugins.
XPNet has not yet adopted the new convention because it is not backward compatible to
older versions of X-Plane.  We will consider adopting the new naming convention when and
if we reach the point where XPNet plugins are no longer supported on any version of X-Plane
old enough to only support the old convention.
```

NOTE: XPNet does not currently have a cross-compiler set up.  To build the native Windows
shim, you have to build on Windows.  To build the macOS shim, you have to build on macOS.
Once the native shims are built, however, you can put them all into the same Plugin folder
(as shown in the `Installing into X-Plane` section above) and distribute that same folder to
any platform you've built for.

No matter what environment you're working in, to build XPNet you'll need the X-Plane SDK first.

1. Download the [X-Plane SDK](http://www.xsquawkbox.net/xpsdk/mediawiki/Download)
2. Set the XPLANESDKPATH environment variable on your system.

The XPLANESDKPATH environment variable tells the build where the X-Plane SDK has been
installed.  For instance:

> XPLANESDKPATH=D:\Projects\XPlane\SDK

It should point to the location where you unzipped the X-Plane SDK; the subdirectories in that
SDK directory are CHeaders, Delphi and Libraries.


### Building XPNet on Windows

To build on Windows, you'll need the following.

1. [Visual Studio 2017 Community](https://visualstudio.microsoft.com/downloads/)
2. [Vcpkg](https://docs.microsoft.com/en-us/cpp/vcpkg?view=vs-2017) _to install native libraries_
3. Google Test (gtest) _recommend installing via Vcpkg - it's like magic_

In the Visual Studio 2017 installer, you'll need "Desktop Development with C++"
and ".NET Core" at least.  XPNet requires C# 7.2, which wasn't included in the
very first release of Visual Studio 2017, so update to the latest version of
Visual Studio 2017 to ensure you have what you need.

From the x64 or x86 Native Tools Command Prompt, run the following:

```cmd
cd path/to/where/you/downloaded/xpnet
nmake /f Makefile.vc
```

Unit tests will be automatically run as part of the build process, and must succeed
for the build to succeed.

If all goes well, build outputs for both 32-bit and 64-bit will be in a directory
named `build` when that completes, and the nuget packages will be in a directory
named `package`.  You can copy those outputs to a directory structure as described in
"Installing into X-Plane" above.

You can also build the project from the IDE by opening XPNet.sln, and can manually create
a plugin directory as described in "Installing Into X-Plane", but for running in X-Plane
the command-line build is recommended.

Further information on the structure of the project, and the unit tests, can be found
in the [TESTING](TESTING.md) document.


### Building XPNet on macOS

To build on macOS, use make.  You'll need recent versions of clang or gcc.
This process was developed and tested on macOS High Sierra using the toolset
that comes with Xcode 9.

```bash
cd path/to/where/you/downloaded/xpnet
make
```

Unit tests will be automatically run as part of the build process, and must succeed
for the build to succeed.

If all goes well, you'll have a bunch of .dll files and a mac.xpl file in a directory
named `build` when that completes, and the nuget packages will be in a directory
named `package`.  You can copy those outputs to a directory structure as described
in "Installing into X-Plane" above.

There is only a 64-bit build for macOS because the .NET Core Runtime does not
support 32-bit MacOS.

Further information on the structure of the project, and the unit tests, can be found
in the [TESTING](TESTING.md) document.


### Building XPNet on Linux

Now that XPNet runs on macOS, we're probably 90% of the way to running on Linux.
The project maintainer doesn't currently have a Linux box with an X-Plane license,
so if someone wants to run that ball the last few yards across the finish line,
I'll look at your pull request.
