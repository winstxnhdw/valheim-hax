@echo off

rmdir /s /q bin
rmdir /s /q "valheim-hax/obj"
cls

dotnet build valheim-hax
start /wait /b ./submodules/SharpMonoInjectorCore/bin/SharpMonoInjector.exe inject -p Valheim -a bin/valheim-hax.dll -n Hax -c Loader -m Load

pause