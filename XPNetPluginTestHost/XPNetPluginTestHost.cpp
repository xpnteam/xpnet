// XPNetPluginTestHost.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"
#include "GoogleTestRunner.h"

int main(int argc, char** argv)
{
	GoogleTestRunner runner(argc, argv);
	return runner.Run();
}
 