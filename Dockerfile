# Étape 1 : Build
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app
COPY . .
RUN dotnet build TP_APP_CONSOLE.sln --configuration Release

# Étape 2 : Publish
RUN dotnet publish TP_APP_CONSOLE.sln --configuration Release --output /publish

# Étape 3 : Runtime
FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "TP_APP_CONSOLE.dll"]

