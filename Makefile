
Configuration   =Release
Platform        =netcoreapp2.0

OutDir          =plugin

all: plugin

xpnetclr:
	cd XPNet.CLR && dotnet publish -c $(Configuration)


loggerplugin:
	cd XPNet.LoggerPlugin && dotnet publish -c $(Configuration)


native:
	cd XPNet.Native && $(MAKE)


native_out: native
	cp XPNet.Native/lib/*.xpl $(OutDir)


prepare_plugin:
	mkdir -p $(OutDir)


plugin: prepare_plugin xpnetclr loggerplugin native_out
	cp XPNet.CLR/bin/$(Configuration)/$(Platform)/publish/*.dll $(OutDir)
	cp XPNet.LoggerPlugin/bin/$(Configuration)/$(Platform)/publish/*.dll $(OutDir)

