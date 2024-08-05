# Use the official .NET image as a base
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Use the SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["SignalRServer.csproj", "."]
RUN dotnet restore "./SignalRServer.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "SignalRServer.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SignalRServer.csproj" -c Release -o /app/publish

# Build runtime image
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SignalRServer.dll"]
