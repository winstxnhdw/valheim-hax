FROM mcr.microsoft.com/dotnet/sdk:6.0

WORKDIR /

COPY . ./

ARG project_name="valheim-hax"
RUN dotnet build ${project_name}
RUN dotnet publish submodules/SharpMonoInjectorCore/SharpMonoInjector
