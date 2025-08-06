@echo off

set project_name=valheim-hax
dotnet build %project_name% -c Release -restoreProperty:RestoreLockedMode=true
start /wait /b ./submodules/SharpMonoInjectorCore/dist/SharpMonoInjector.exe inject -p valheim -a bin/%project_name%.dll -n Hax -c Loader -m Load

pause
