FROM microsoft/dotnet:2.0-runtime AS base
WORKDIR /app

FROM microsoft/aspnetcore-build:2.0 AS build
WORKDIR /src
COPY *.sln ./
COPY DemoVolumeMapping/DemoVolumeMapping.csproj DemoVolumeMapping/
RUN dotnet restore
COPY . .
WORKDIR /src/DemoVolumeMapping
RUN dotnet build -c Release -o /app

FROM build AS publish
RUN dotnet publish -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "DemoVolumeMapping.dll"]
