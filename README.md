# XPNet

Develop [X-Plane](http://www.x-plane.com/) plugins in .NET.

:email: Follow [XPNetSim](http://twitter.com/xpnetsim) on Twitter for release notifications and news.

## What Is This?

XPNet is an API binding for writing plugins in C# or other .NET languages for the X-Plane
flight simulator.

The design goals for XPNet are:

1. Provide excellent performance: it should be possible to write plugins in C# that don't kill your framerate.
2. Provide an idiomatic .NET programming environment: that means classes, events and properties, where doing so does not conflict too badly with #1.
3. Don't stray too far from X-Plane core concepts: meaning #2 only goes so far, so the X-Plane API documentation is a decent guide to the concepts neeed to write a plugin for X-Plane in C#.
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

XPNet is a new project and there are a ton of ways it could be improved.  At present, someone
with a fair amount of experience with .NET, DLLs and dependencies, and software deployment, or who is willing to
jump in and learn those things, can use XPNet to develop a plugin that reads and writes DataRefs and does
scheduled background processing (such as communicating on a network or serial port).  XPNet is
being used in the development of just such a plugin.

With the help of contributors, I'd like to see XPNet grow in at least the following ways:

- [ ] Expand to Linux.  (We already run on macOS, so we're most of the way to Linux, for someone with good C/C++ and relevant platform experience.)
- [ ] Automatically find the plugin to load in simple cases based on naming convention rather than requiring a config entry.  I tried to do this from the start but it appears that System.Reflection.Metadata is just fundamentally broken in .NET Core, and things like Cecil don't work on Core (at least not in the effort I'm willing to put into it).  When the Core tooling gets better, or someone wants to contribute who can provide a solution, revisit this.
- [x] Build out the Fluent Data API.  What we have so far is more a concept than anything.  Possibly this is a template/tool that creates the Fluent API from the DataRefs.txt that comes with X-Plane, instead of building the thing by hand.
- [ ] Extend the test harness to be more generally useful for other plugins beyond the sample Logging plugin.
- [ ] Improve the native output directory structure for the C++ VS 2017 projects - by default, for backwards compatibility, MS makes project outputs inconsistent between x86 and x64 builds.  It all works...but is unnecessarily confusing.
- [x] Publish a nuget package to make it easy to create a plugin.  The package should ideally be "fat", including binaries for Windows, macOS and Linux in appropriate arch subdirectories, so that you can easily create plugin projects that reference XPNet and which you can then just xcopy-deploy into X-Plane.
- [x] 2018-02-25 - Expand to macOS.
- [x] 2018-07-25 - Implement tooling or procedures to make it easier to create a plugin and get it installed or distributed.  ('dotnet new' template)
- [x] 2017-09-08 - Automatically detect and use any compatible .NET Core install found in <Plugin-Path>/64/dotnet (or <Plugin-Path>/32/dotnet) instead of assuming release 1.1.1.

Additionally, the following aspects of the X-Plane API need mappings to XPNet.

- [ ] Registering custom DataRefs (to expose to other plugins).
- [ ] XPLMDisplay
- [ ] XPLMMenus
- [ ] XPLMGraphics
- [ ] XPLMUtilities
- [ ] XPLMCamera
- [ ] XPLMPlanes
- [ ] XPLMNavigation
- [ ] Widgets (XPLMWidgets / XPLMWidgetDefs / XPLMWidgetUtils / XPLMStandardWidgets)
- [ ] XPUIGraphics
- [ ] XPLMScenery
- [ ] XPLM Feature Keys


## Developing a Plugin

You can develop plugins with Visual Studio 2017 Community or higher, or with the .NET Core SDK 2.0 or higher.
Both Visual Studio 2017 Community, and the .NET Core SDK, are free [(as in beer)](https://en.wikipedia.org/wiki/Gratis_versus_libre)
downloads from Microsoft.

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
.NET SDK v2.0 or higher installed.  These instructions work for Windows and macOS.

1. Create a directory for your new project.

2. Install or update the 'dotnet new' template for XPNet.

```
dotnet new -i XPNet.CLR.Template
```

3. Create a new plugin project.
```
dotnet new xpnetplugin -n YourPluginName
```

That will leave you with a new project (a .csproj file) and a single C# code file with an
empty plugin class.

Happy coding!

When you're ready to build and run your plugin, run the following command from the
directory that contains your .csproj file.

```
dotnet publish -c Debug
```

Running the publish command will build your plugin and place it, and most of
the rest of what you need, in a directory on disk like so:

> YourProjectRoot/bin/Debug/netcoreapp2.0/publish

The exact location will vary depending on which version of .NET Core you are
targetting, your release configuration, etc.  To deploy to X-Plane, copy the
contents of that publish directory into a new plugin folder in X-Plane,
download and place a compatible .NET Core hosting runtime in the same folder,
and start X-Plane.  See the section `Installing into X-Plane` below for
details.

To build in Release mode for distribution, just specify Release configuration
and look in the corresponding Release directory on disk for the output.

```
dotnet publish -c Release
```


### Creating a Project Manually with Visual Studio

If you're intent on rolling your own instead of using the starter project, or if you want to
build XPNet yourself instead of using the prebuilt nuget packages, you can start a
project from Visual Studio and set it all up manually.  Some pointers for doing it this way:

1. When creating your plugin project, start a new "Class Library (.NET Core)" project.  (You want ".NET Core", not ".NET Standard".  Look under "Templates -> Visual C# -> .NET Core").
2. If you're using the nuget packages instead of building XPNet yourself, the packages to get are `XPNet.CLR`, `XPNet.Native.macOS` and `XPNet.Native.Windows`.  You want _all_ the native packages, not just the ones for the platform you're buliding on, or your plugin won't be able to work on any platform other than the one you developed it on.



## Installing into X-Plane

Installing into X-Plane involves copying various files into the correct place in
an X-Plane install.  You must build or obtain either or both 32-bit and 64-bit
builds of the following:

* [.NET Core](https://www.microsoft.com/net/download/core)
* XPNet Build Outputs (XPNet.Native.dll, XPNet.CLR.dll, and nuget dependencies like Newtonsoft.Json).
* Your built plugin DLL and its dependencies (if any).

For .NET Core, you want the binaries (.zip file), not the installer,
because you'll unzip and copy the .NET Core install into the correct location.

XPNet currently assumes that it will be running against .NET Core 2.0 or above.

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

Use Visual Studio 2017 or above to open and build XPNet.sln.  To build for both 32-bit
and 64-bit, you will build twice: once with the x64 configuration selected and once
with the x86 configuration selected.  Gather the output files
and drop them into a folder in X-Plane as described in "Installing Into X-Plane" above.

```
"Gathering the output files" in Windows involves tracking down the several
dependent DLLs that XPNet.CLR references, and grabbing the native and .NET
outputs from a couple of different projects in the solution file.  It would be great to
have a working 'dotnet publish' command for Windows (like how it
works for macOS; see below), but the build includes native components so
'dotnet publish' won't work on its own.  The likely improvement to make is
to create an MSBuild target that could be invoked from
the command line.  You _can_ do a Publish action from Visual Studio and have it
gather all the files for you, but it's a more complicated and cumbersome process
to set up than the command line version.  Now that we have the nuget packages,
most people should be using them, so there are no immediate plans to further
automate the process of building a Plugin folder in the Visual Studio workflow.
If someone is interested, though, I would consider pull requests for better instruction
text to place here, or tooling improvements for building on Windows, especially
an MSBuild target that builds everything for both 32-bit and 64-bit and drops it
all in a Plugin folder with the right structure.
```


### Building XPNet on macOS

To build on macOS, use make.  You'll need recent versions of clang or gcc.
This process was developed and tested on macOS High Sierra using the toolset
that comes with Xcode 9.

```bash
cd path/to/where/you/downloaded/xpnet
make
```

If all goes well, you'll have a bunch of .dll files and a mac.xpl file in a directory
named `plugin` when that completes.  Create a plugin directory structure as described in
"Installing into X-Plane" above, and copy everything from the `plugin`
folder you just built.

<aside class="notice">
The macOS build currently only supports creating 64-bit binaries.  Making a 32-bit
build shouldn't be hard, and I would accept a pull request to add one.  We would
want a result that builds both platforms side-by-side, ready to drop into the 32
and 64 directories in an X-Plane plugin directory.
</aside>


### Building XPNet on Linux

Now that XPNet runs on macOS, we're probably 90% of the way to running on Linux.
The project maintainer doesn't currently have a Linux box with an X-Plane license,
so if someone wants to run that ball the last few yards across the finish line,
I'll look at your pull request.
