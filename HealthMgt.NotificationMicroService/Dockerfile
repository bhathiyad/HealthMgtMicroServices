FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["HealthMgt.NotificationMicroService/HealthMgt.NotificationMicroService.csproj", "HealthMgt.NotificationMicroService/"]
RUN dotnet restore "HealthMgt.NotificationMicroService/HealthMgt.NotificationMicroService.csproj"
COPY . .
WORKDIR "/src/HealthMgt.NotificationMicroService"
RUN dotnet build "HealthMgt.NotificationMicroService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HealthMgt.NotificationMicroService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HealthMgt.NotificationMicroService.dll"]