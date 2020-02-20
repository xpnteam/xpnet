
# TODO: As soon as we can use C++17 std::filesystem on macOS with the compilers that come with Xcode,
# remove the boost dependency here.  I didn't want to depend on boost for this, and we only need it
# for its filesystem implementation.
#
BOOSTLIB =/usr/local/opt/boost/lib

UNAME         :=$(shell uname)

CXX           :=g++
RM            :=rm -f
CPPFLAGS      :=-g -Wall -std=c++1z -m64 -c
OUTROOT       :=../build/test
OBJDIR        :=obj
BINDIR        :=bin
SRCDIR        :=.
LDFLAGS       :=-g -Wall
LDLIBS        :=

Configuration :=Release

INC           :=-I$(XPLANESDKPATH)/CHeaders/Widgets -I$(XPLANESDKPATH)/CHeaders/Wrappers -I$(XPLANESDKPATH)/CHeaders/XPLM -I../XPNet.Native

ifeq ($(UNAME),Linux)
  
  # TODO: I set up for Linux as best I could from a non-Linux OS.  I don't have X-Plane on
  # Linux here to go further.  If someone fixes this and sends in a pull request, remove this
  # TODO; it's just here to mark that, though this _looks_ like it supports Linux, it may
  # not quite be there yet; needs someone to tweak it until it works and contribute that back.

  PLATFORM    :=Linux
  DEFINES     :=-DAPL=0 -DIBM=0 -DLIN=1 -DPLATX64=1
  LIBNAME     :=XPLM_64
  OUTNAME     :=$(LIBNAME).so

endif


ifeq ($(UNAME),Darwin)

  PLATFORM    :=macOS
  DEFINES     :=-DAPL=1 -DIBM=0 -DLIN=0 -DPLATX64=1
  LIBNAME     :=XPLM
  OUTNAME     :=$(LIBNAME)
  MOCKRESROOT :=$(OUTROOT)/Resources
  OUTPATH     :=$(MOCKRESROOT)/plugins/XPLM.framework
  FRAMEWORKS  :=-install_name @executable_path/../XPLM.framework/XPLM
  LDFLAGS     :=$(LDFLAGS) $(BOOSTLIB)/libboost_system.a $(BOOSTLIB)/libboost_filesystem.a

endif



# ================================================

SRCS          =XPLMTestHarness.cpp

_OBJS         =$(subst .cpp,.o,$(SRCS))
OBJS          =$(patsubst %,$(OBJDIR)/%,$(_OBJS)) $(OBJDIR)/Platform.o

XPLMLIB       =$(OUTPATH)/$(OUTNAME)

# ================================================

all: harness

harness: $(XPLMLIB)

$(XPLMLIB): buildprep $(OBJS)
	$(CXX) $(LDFLAGS) -shared -o $(XPLMLIB) $(OBJS) $(LDLIBS) $(FRAMEWORKS)

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
	$(RM) -r $(OUTPATH)/$(OUTNAME) $(MOCKRESROOT) $(OBJDIR) $(BINDIR)

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
	mkdir -p $(OUTPATH)
	mkdir -p $(OBJDIR)

