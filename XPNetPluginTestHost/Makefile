
# TODO: As soon as we can use C++17 std::filesystem on macOS with the compilers that come with Xcode,
# remove the boost dependency here.  I didn't want to depend on boost for this, and we only need it
# for its filesystem implementation.
#
BOOSTLIB =/usr/local/opt/boost/lib

UNAME         :=$(shell uname)

CXX           :=g++
RM            :=rm -f
CP            :=cp
MKDIR         :=mkdir -p
CPPFLAGS      :=-g -Wall -std=c++1z -m64 -c
OUTROOT       :=../build/test
OBJDIR        :=obj
BINDIR        :=bin
SRCDIR        :=.
LDFLAGS       :=-g -Wall
LDLIBS        :=

BUILDDIR      :=../build
XPLLIBNAME    :=mac.xpl

Configuration :=Release

INC           :=-I$(XPLANESDKPATH)/CHeaders/Widgets -I$(XPLANESDKPATH)/CHeaders/Wrappers -I$(XPLANESDKPATH)/CHeaders/XPLM -I../XPNet.Native -I../XPLMTestHarness

ifeq ($(UNAME),Linux)
  
  # TODO: I set up for Linux as best I could from a non-Linux OS.  I don't have X-Plane on
  # Linux here to go further.  If someone fixes this and sends in a pull request, remove this
  # TODO; it's just here to mark that, though this _looks_ like it supports Linux, it may
  # not quite be there yet; needs someone to tweak it until it works and contribute that back.

  PLATFORM    :=Linux
  DEFINES     :=-DAPL=0 -DIBM=0 -DLIN=1
  OUTNAME     :=XPNetPluginTestHost

endif


ifeq ($(UNAME),Darwin)

  PLATFORM    :=macOS
  DEFINES     :=-DAPL=1 -DIBM=0 -DLIN=0
  MOCKRESROOT :=$(OUTROOT)/Resources
  OUTDIR      :=$(MOCKRESROOT)/plugins/XPNetPluginTest
  OUTNAME     :=XPNetPluginTestHost

  # NOTE: Important to note that we're pointing to our harness XPLM framework instead of the real one here.
  FRAMEWORKS  :=-F$(MOCKRESROOT)/plugins -framework XPLM 

  LDFLAGS     :=$(LDFLAGS) -lgtest $(BOOSTLIB)/libboost_system.a $(BOOSTLIB)/libboost_filesystem.a

endif



# ================================================

SRCS          =$(wildcard $(SRCDIR)/*.cpp)

_OBJS         =$(subst .cpp,.o,$(SRCS))
OBJS          =$(patsubst %,$(OBJDIR)/%,$(_OBJS)) $(OBJDIR)/Platform.o

TESTEXE       =$(OUTDIR)/$(OUTNAME)

# ================================================

all: testhost

test: testhost testprep
	(cd $(OUTDIR) && ./$(OUTNAME))

testhost: $(TESTEXE)

testprep:
	# Need the .NET binaries (the test plugins, etc.)
	$(MKDIR) $(OUTDIR)/64/
	$(CP) ../build/*.xpl $(OUTDIR)/64/
	#$(CP) ../build/*.dll $(OUTDIR)
	dotnet publish ../XPNet.CLR -c $(Configuration) -o "$(OUTDIR)"
	dotnet publish ../XPNet.LoggerPlugin -c $(Configuration) -o "$(OUTDIR)"
	dotnet publish ../XPNet.CLR.TestPlugins -c $(Configuration) -o "$(OUTDIR)"
	dotnet publish ../XPNet.GraphicsTestPlugin -c $(Configuration) -o "$(OUTDIR)"
	# Need a set of embedded .NET runtimes to run against.
	dotnet install -i "$(OUTDIR)/64/dotnet-windows" -r dotnet -p win -a x64 -v 2.1
	dotnet install -i "$(OUTDIR)/64/dotnet-macos" -r dotnet -p osx -a x64 -v 2.1
	dotnet install -i "$(OUTDIR)/32/dotnet-windows" -r dotnet -p win -a x86 -v 2.1

$(TESTEXE): buildprep $(OBJS)
	$(CXX) $(LDFLAGS) -o $(TESTEXE) $(OBJS) $(LDLIBS) $(FRAMEWORKS) -L$(BUILDDIR) $(BUILDDIR)/$(XPLLIBNAME)
	#$(CXX) $(LDFLAGS) -o $(TESTEXE) $(OBJS) $(LDLIBS) $(FRAMEWORKS) -L$(BUILDDIR) $(BUILDDIR)/$(XPLLIBNAME) -Wl,-rpath,./

$(OBJDIR)/%.o: $(SRCDIR)/%.cpp
	$(CXX) $(CPPFLAGS) $(DEFINES) $(INC) -o $@ $<

$(OBJDIR)/Platform.o: ../XPNet.Native/Platform.cpp
	$(CXX) $(CPPFLAGS) $(DEFINES) $(INC) -o $@ $<

depend: .depend

.depend: $(SRCS)
	$(RM) ./.depend
	$(CXX) $(CPPFLAGS) $(DEFINES) $(INC) -MM $^>>./.depend;

clean:
	$(RM) $(OBJS)
	$(RM) -r $(OUTDIR)/$(OUTNAME) $(MOCKRESROOT) $(OBJDIR) $(BINDIR)

distclean: clean
	$(RM) *~ .depend

include .depend


check-env:
ifndef XPLANESDKPATH
  $(error XPLANESDKPATH is undefined.  You must set it before you can build XPNet)
endif
ifndef PLATFORM
  $(error Platform not yet supported.  If you are on Windows, use Visual Studio 2017 or above, or NMake with Makefile.vc)
endif


buildprep:
	mkdir -p $(OUTDIR)
	mkdir -p $(OBJDIR)
	$(CP) $(BUILDDIR)/$(XPLLIBNAME) $(OUTDIR)

