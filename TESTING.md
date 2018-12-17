# XPNet Testing

This document assumes familiarity with the basic concepts of [automated unit testing](https://en.wikipedia.org/wiki/Unit_testing).
If you don't know how to write a unit test or what a mock is, you'll be well-served to go do some reading first, then come back.

## Testing on Windows

Open XPNet.sln in Visual Studio and you can develop and run tests from the Test Explorer window.
Newer versions of Visual Studio 2017 come with the Test Explorer provider for Google Test
pre-installed, so updated to the latest Visual Studio and it should find the tests on its own
after you build the solution once.  You must build the solution for new native test cases to
become visible to Test Explorer.

When you build from the command line as described in the [README](README.md), the unit tests are run
automatically as part of the build process.

You can also run the tests standalone from the command line, by running the output of the
XPNetPluginTestHost project (_XPNetPluginTestHost.exe_).  Note that
the current working directory needs to be the directory that contains
_XPNetPluginTestHost.exe_, in the _build_ output tree, or the tests will
fail, b/c they need to be able to find dependencies like XPNet.CLR.dll
and to probe for a dotnet core runtime in the expected locations.


## Testing on macOS

TODO: Get the tests to run on macOS.


## Projects

### Primary Projects

* _XPNet.Native_ - The native side of the XPNet plugin system.  Compiles to a DLL that X-Plane loads; from X-Plane's standpoint, this project's output _is_ the plugin.
* _XPNet.CLR_ - The .NET side of the XPNet plugin system.  XPNet.Native loads a .NET runtime and then loads XPNet.CLR, which in turn loads and runs your plugin.

### Test Projects

* _XPNet.CLR.Tests_ - Automated unit tests for XPNet.CLR, written using [xUnit](https://xunit.github.io/).  Much of XPNet.CLR is also tested as part of the end-to-end native tests (below).
* _XPNetPluginTestHost_ - Automated unit tests for the C/C++ side of the plugin, written using [Google Test](https://github.com/abseil/googletest/).  Many of these tests are also end-to-end tests which load a runtime and invoke parts of XPNet.CLR as well.
* _XPLMTestHarness_ - A set of mocks that serve as a stand-in for X-Plane's SDK.

## The Native Tests

The tests in _XPNetPluginTestHost_ test the functionality of _XPNet.Native_.  During the set-up phase
of its tests, _XPNetPluginTestHost_ calls functions to set up mock behavior in _XPLMTestHarness_.
The tests then make one or more calls into _XPNet.Native_, and then make additional calls to the
mocking API in _XPLMTestHarness_ to verify whether the correct functions were called with the
correct arguments.

The _XPLMTestHarness_ project compiles to a file with the same name as X-Plane's SDK DLL
(e.g., XPLM.dll for Windows 32-bit; other similar names for other platforms and architectures).
That project exposes two APIs: a "mock" C API that looks just like the X-Plane's SDK, and
a "setup" C API that allows the mock API to be seeded with mock data (in the setup phase) and get callbacks, etc.
when calls are made into it.

In addition to testing XPNet.Native, the native tests in XPNetPluginTestHost also execute much of
the functionality of the XPNet.CLR project as well, since much of what is being tested is that
the details of the native-to-.NET SDK mappings are correct, and you need that native test harness
to help verify as much.

When X-Plane is running with an XPNet plugin installed, a typical call stack looks roughly like this.
(I used the Windows 32-bit DLL/XPL names here; replace with whichever is the right name for
your platform).

[X-Plane.exe] --> [win.xpl (XPNet.Native)] --> [YourPlugin.dll] --> [XPLM.dll (X-Plane SDK)]

I.e., X-Plane calls into the XPNet native plugin, which calls into your .NET plugin, which
then talks back to X-Plane via the XPLM DLL.  Presumably, X-Plane.exe and XPLM.dll are also
talking with each other behind the scenes.

In contrast, here is a typical native test call stack.

[XPNetPluginTestHost.exe] --> [XPNet.Native.dll (XPNet.Native)] --> [LoggerPlugin.dll] --> [XPLM.dll (XPLMTestHarness)]

Of note:

* Here, the role of XPLM.dll is played by our mock SDK in XPLMTestHarness, rather than X-Plane's real SDK.
* LoggerPlugin is used in many of the tests, but it's just an example; other plugin DLLs are used in other tests as well.
* In this configuration, the native DLL has its "normal" name (XPNet.Native.dll), but it's the same code.  There are some technical reasons why this is better on Windows; it really doesn't matter on other platforms.  When installed into X-Plane, the DLL is renamed to win.xpl to make (older versions of) X-Plane happy.
* Just as in the "real" call stack, our X-Plane standin (XPNetPluginTestHost) and our SDK standin (XPLMTestHarness) are also talking to each other behind the scenes, in this case to set up mocks and verify test results as described above.


## The XPNet.CLR Tests

Much of the .NET code is covered by the native tests, as described above.  Additionally,
some portions of the .NET code have their own dedicated tests, found in XPNet.CLR.Tests.
Those tests are much simpler than the native tests above: they are just normal .NET
xUnit tests, which can be run by any compatible test runner (including `dotnet test`)
and with no native code involved.

To run the XPNet.CLR tests standalone, `cd` into the XPNet.CLR.Tests directory and
run:

```
dotnet test -c Release -p:Platform=AnyCPU
```

The configuration and platform are required; there is no valid default configuration
and the build will fail without them.  You can also use any other compatible .NET test
runner that you like, including the Test Explorer window in Visual Studio 2017 and above.



## Notes on additional enhancements

ENHANCE: For Windows, combine the output directories to be in a 'plugin' subdirectory instead of
the 'build' subdirectory and to put both x32 and x64 in the same output tree, so
that you have _one_ final plugin directory that works correctly when you're done.
To do that, _might_ want to move the 'dotnet package' calls into the makefile
instead of vcxproj build events, so that they can be done once for a combined output
instead of twice...look at the workflow and make a decision.
Actually...maybe make the default build action for the dependent projects in the
solution be publish, with the publish output set to the single shared directory,
instead of build - that _might_ solve the double-publish problem right away, and
may also solve the problem where we have to manually rebuild XPNetPluginTestHost
when you change something over in XPNet.CLR or XPNet.CLR.TestPlugins b/c the
_dependency_ is there, but VS doesn't know that to actually get the updated
code it's got to re-run the publish step that is currently just an after-build
step of XPNetPluginTestHost.

TODO: 'nmake clean' on Windows breaks tests until you manually delete the 'build' folder b/c it deletes files but not folders - fools the .NET install.

TODO: Set up automated testing with Travis or whatever.  Travis is available on
Windows now!  https://blog.travis-ci.com/2018-10-11-windows-early-release

TODO: Get builds for the 'dotnet install' project running on Travis on Windows.

TODO: Since they've got Windows travis builds now...I could probably set up an artifact
repository (I bet there are open source ones) and set up something where it publishes
to nuget automatically when I build from a tag or something like that.

TODO: Now that LoggerPlugin isn't part of the automated test suite anymore, probably
move it to its own repository, as an example of how to do your own plugin _using_ XPNet.
