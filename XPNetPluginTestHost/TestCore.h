#pragma once

#include "XPNetPluginTestHost.h"
#include <XPNetPlugin.h>
#include <XPLMTestHarness.h>
#include "XPMock.h"

#include <iostream>
#include <fstream>

#include <string>
#include <cstring>
#include <functional>

#define GTEST_LINKED_AS_SHARED_LIBRARY 1

#include <gtest/gtest.h>
#include <gmock/gmock.h>

using ::testing::HasSubstr;
using ::testing::ElementsAre;

using std::function;
using std::string;

string xpnetcfg_path();
string xpnetlog_path();

inline bool file_exists(const std::string& name)
{
	struct stat buffer;
	return (stat(name.c_str(), &buffer) == 0);
}

typedef enum {
	XPNC_None = 0x0,

	XPNC_EnableLogging = 0x01
} XPNetConfigFlags;

#define DataRefBase "xpnet/test/"

void DeleteXPNetConfig();
void WriteXPNetLoggerPluginConfig(XPNetConfigFlags flags);
void WriteTestPluginConfig(const string& name, XPNetConfigFlags flags);

#define RunPlugin(...) ASSERT_NO_FATAL_FAILURE(RunPluginImpl(__VA_ARGS__))

void RunPluginImpl(const string& name);
void RunPluginImpl(const string& name, function< void(void) > postEnableCallback);
void RunPluginImpl(const string& name, function< void(void) > postEnableCallback, function< void(void) > postDisableCallback);

class PluginTestsBase : public ::testing::Test
{
	virtual void SetUp() { SetUpPluginTest(); }

	virtual void TearDown() { TearDownPluginTest(); }

public:
	static void SetUpPluginTest();
	static void TearDownPluginTest();

	static string LogOutput();
};
