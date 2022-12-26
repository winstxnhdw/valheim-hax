@echo off

rmdir /s /q "valheim-hax/References/NuGet"
cls

dotnet build valheim-hax
start /wait /b ./submodules/SharpMonoInjectorCore/bin/SharpMonoInjector.exe inject -p valheim -a bin/valheim-hax.dll -n Hax -c Loader -m Load

pause