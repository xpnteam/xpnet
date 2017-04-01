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

* DataRefs (reading and writing data fields in X-Plane)
* Processing (plugging into the X-Plane processing loop to do periodic processing)

XPNet is a new project and there are a ton of ways it could be improved.  At present, someone
with a fair amount of experience with .NET, DLLs and dependencies, and software deployment, or who is willing to
jump in and learn those things, can use XPNet develop a plugin that reads and writes DataRefs and does
scheduled background processing (such as communicating on a network or serial port).  XPNet is
being used in the development of just such a plugin.

The following are currently actively being worked on:

* Implement tooling or procedures to make it easier to create a plugin and get it installed or distributed, with an immediate focus on Windows 32-bit and 64-bit.

With the help of contributors, I'd like to see XPNet grow in at least the following ways:

* Expand to macOS and Linux.  (Most of the native code is written in standard C or C++ so the effort here should be moderate for someone with good C/C++ and relevant platform experience.)
* Expose more of the X-Plane API.  We've got Data and Processing covered so far; there are several other major subsystems, like Graphics, Camera, Planes, Navigation, and so on.

There are also some specific parts of the API and usage experience that could be improved.

* Automatically find the plugin to load in simple cases based on naming convention rather than requiring a config entry.  I tried to do this from the start but it appears that System.Reflection.Metadata is just fundamentally broken in .NET Core, and things like Cecil don't work on Core (at least not in the effort I'm willing to put into it.)  When the Core tooling gets better, or someone wants to contribute who can provide a solution, revisit this.
* Publish a nuget package to make it easy to create a plugin.  The package should ideally be "fat", including binaries for Windows, macOS and Linux in appropriate arch subdirectories, so that you can easily create plugin projects that reference XPNet and which you can then just xcopy-deploy into X-Plane.
* Build out the Fluent Data API.  What we have so far is more a concept than anything.  Possibly this is a template/tool that creates the Fluent API from the DataRefs.txt that comes with X-Plane, instead of building the thing by hand.
* Extend the test harness to be more generally useful for other plugins beyond the sample Logging plugin.

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
* IXPlanePlugin.Enable corresopnds to XPluginEnable.
* IXPlanePlugin.Disable corresponds to XPluginDisable.

During your development, you'll have to be sure that you stay within the confines of
what is available on .NET Core.  Describing exactly what that means is beyond the scope
of this document.  .NET Core is a full-featured CLR runtime, not a "stripped-down" version
of .NET, but it /does/ have some differences from the traditional .NET Framework.

Additionally, if you really only care if your plugin works on Windows, you could make
some modifications to the

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

## Deploying into X-Plane

TODO: Write about the directory structure and where to put the plugin.


## Logging

On initial startup, XPNet writes into the X-Plane log (Log.txt).  Look in that
log for information about whether the plugin can load in the first place.  If
X-Plane is unable to load the XPNet plugin, or if the XPNet plugin is unable to
initialize the .NET runtime, then error messages about that will appear in the
X-Plane Log.txt

Once XPNet gets going, it provides a separate logging mechanism that can be turned on and
off by editing the _xpnetcfg.json_ configuration file.  Extensive logging can be a significant
performance hit, so it is recommended that you use logging to test your plugin but deliver
the plugin to users with logging turned off, and provide instructions
to end-users for how to turn logging on if it is necessary to find a solution to a problem.

When enabled, the log file is written in UTF-8 encoding to the file _xpnet.log_ in the plugin
directory.


## Async / Threading

XPNet supports but does not provide particular facilities for asynchronous / threaded operations.

XPNet does not provide any threading capabilities on its own.  Unless otherwise specified,
all events and methods are raised or called on X-Plane's user interface thread.  Additionally,
again unless otherwise specified, XPNet is not internally threadsafe.  This helps keep the
library performant, and frankly many scenarios don't need any asynchronous behavior.

If your scenario does need threaded or asynchronous behavior, however, by all means kick off
what you need to.  The rule is: if you're calling back to X-Plane or XPNet, including reading
DataRefs or writing to the log, make that call on the UI thread.

You should consider using constructs like the async/await keywords in C#, rather than directly
working with Threads.  Threaded operation is beyond the scope of this documentation, but it is
not discouraged for those who know what they're doing.
