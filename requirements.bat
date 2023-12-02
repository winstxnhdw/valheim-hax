@echo off

set project_name=valheim-hax
dotnet build %project_name%
dotnet publish submodules/SharpMonoInjectorCore/SharpMonoInjector
