# XPNet

Develop [X-Plane](http://www.x-plane.com/) plugins in .NET.

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
works on more than just Windows, and many of the "edges" of the base class library
have been cleaned up.

An XPNet plugin consists of three parts:

1. A native .DLL/.SO, compiled for each OS and architecture, which is what X-Plane sees and loads as a plugin.  The native wrapper creates a CLR runtime inside of X-Plane and runs the plugin inside it.  XPNet provides this piece.
2. A .NET API layer, which implements the XPNet API on top of the X-Plane API.  XPNet provides this piece.
3. A .NET class that implements IXPlanePlugin and provides your plugin logic.  You provide this piece.

## TODOs

XPNet currently runs on Windows and exposes the following subsystems of the X-Plane API:

- [x] Reading and writing DataRefs (data fields provided by X-Plane or other plugins)
- [x] Processing (plugging into the X-Plane processing loop to do periodic processing)

XPNet is a new project and there are a ton of ways it could be improved.  At present, someone
with a fair amount of experience with .NET, DLLs and dependencies, and software deployment, or who is willing to
jump in and learn those things, can use XPNet develop a plugin that reads and writes DataRefs and does
scheduled background processing (such as communicating on a network or serial port).  XPNet is
being used in the development of just such a plugin.

The following are currently actively being worked on:

- [ ] Implement tooling or procedures to make it easier to create a plugin and get it installed or distributed, with an immediate focus on Windows 32-bit and 64-bit.

With the help of contributors, I'd like to see XPNet grow in at least the following ways:

- [ ] Expand to macOS and Linux.  (Most of the native code is written in standard C or C++ so the effort here should be moderate for someone with good C/C++ and relevant platform experience.)
- [ ] Automatically detect and use any compatible .NET Core install found in <Plugin-Path>/64/dotnet (or <Plugin-Path>/32/dotnet) instead of assuming release 1.1.1.
- [ ] Automatically find the plugin to load in simple cases based on naming convention rather than requiring a config entry.  I tried to do this from the start but it appears that System.Reflection.Metadata is just fundamentally broken in .NET Core, and things like Cecil don't work on Core (at least not in the effort I'm willing to put into it).  When the Core tooling gets better, or someone wants to contribute who can provide a solution, revisit this.
- [ ] Publish a nuget package to make it easy to create a plugin.  The package should ideally be "fat", including binaries for Windows, macOS and Linux in appropriate arch subdirectories, so that you can easily create plugin projects that reference XPNet and which you can then just xcopy-deploy into X-Plane.
- [ ] Build out the Fluent Data API.  What we have so far is more a concept than anything.  Possibly this is a template/tool that creates the Fluent API from the DataRefs.txt that comes with X-Plane, instead of building the thing by hand.
- [ ] Extend the test harness to be more generally useful for other plugins beyond the sample Logging plugin.

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

These instructions are for developing on Windows.  XPNet is intended to build on macOS
and Linux as well.  Contributions of build scripts, project files and instructions for
building on other platforms are welcome.

These instructions assume Visual Studio 2017.  XPNet can be built using Visual Studio
Community 2017, which is a free [(as in beer)](https://en.wikipedia.org/wiki/Gratis_versus_libre)
download from Microsoft.  You'll need 2017 or higher because XPNet is written using C# 7 syntax.

1. Download and build XPNet in Release/x86 or Release/x64.  (In the future, we want to have a nuget project for this, but in a final solution there are multi-platform native binaries involved so this will take some work.)
2. Start a new "Class Library (.NET Core)" project.  (You want ".NET Core", not ".NET Standard".  Look under "Templates -> Visual C# -> .NET Core").
3. Add a reference to XPNet.CLR.dll.
4. Create a plugin class and develop your plugin.  See below for more details.
5. Deploy into X-Plane.  See below for more details.

## Writing a Plugin Class

A plugin class must meet three requirements.

1. Implement the XPNet.IXPlanePlugin interface.
2. Add the XPlanePlugin attribute to the class.
3. Create a public constructor on the class that accepts one parameter of type IXPlaneApi.

You should read the docs for writing plugins in X-Plane.  The core concepts are the same.

* [X-Plane API Docs](http://www.xsquawkbox.net/xpsdk/mediawiki/Main_Page)
* Your plugin's constructor corresponds to XPluginStart.
* Your plugin's Dispose method corresponds to XPluginStop.
* IXPlanePlugin.Enable corresponds to XPluginEnable.
* IXPlanePlugin.Disable corresponds to XPluginDisable.

During your development, you'll have to be sure that you stay within the confines of
what is available on .NET Core.  Describing exactly what that means is beyond the scope
of this document.  .NET Core is a full-featured CLR runtime, not a "stripped-down" version
of .NET, but it /does/ have some differences from the traditional .NET Framework.

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

## Installing into X-Plane

Installing into X-Plane involves copying various files into the correct place in
an X-Plane install.  You must build or obtain either or both 32-bit and 64-bit
builds of the following:

* [.NET Core](https://www.microsoft.com/net/download/core)
* XPNet Build Outputs (XPNet.Native.dll, XPNet.CLR.dll, and nuget dependencies like Newtonsoft.Json).
* Your built plugin DLL and its dependencies (if any).

For .NET Core, you want the binaries (.zip file), not the installer,
because you'll unzip and copy the .NET Core install into the correct location.

XPNet currently assumes that it will be running against .NET Core 1.1.1.  It
can be easily built against other versions.  In the future, we want to have XPNet
auto-detect and use whatever version you give it.

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
    └───32\                            <-- Same as 64 below, but with 32-bit binaries.
    |
    └───64\
        |
        └─── dotnet\                   <-- Unzip dotnet-win-x64.1.1.1.zip here.
        |    └───host\
        |    └───shared\
        |    └───etc.
        └───win.xpl                    <-- Rename XPNet.Native.xpl and place it here.
        └───XPNet.CLR.dll
        └───XPNet.LoggerPlugin.dll     <-- Your plugin DLL.
        └───xpnetcfg.json              <-- The XPNet Configuration File
        └───Microsoft.Extensions.*.dll <-- These and other DLLs that are required dependencies of XPNet.
```

From X-Plane's standpoint, the actual plugin is a DLL or SO that is
named win.xpl, lin.xpl or mac.xpl.  XPNet provides this library via
a native "shim" project called XPNet.Native, which on Windows / VS 2017
builds a file named XPNet.Native.dll.  Rename that file to win.xpl and drop it into
the correct location.  In the future, Linux and macOS builds of that
native shim would provide us with lin.xpl and mac.xpl as well.

This is all straightforward, but it should be automatable as well, so
a nice future enhancement is tooling or build outputs that build this
tree for you in a cross-platform way, ready to copy into X-Plane.

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
