FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["HealthMgt.OnlineAppointmentMgt/HealthMgt.OnlineAppointmentMgt.csproj", "HealthMgt.OnlineAppointmentMgt/"]
RUN dotnet restore "HealthMgt.OnlineAppointmentMgt/HealthMgt.OnlineAppointmentMgt.csproj"
COPY . .
WORKDIR "/src/HealthMgt.OnlineAppointmentMgt"
RUN dotnet build "HealthMgt.OnlineAppointmentMgt.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HealthMgt.OnlineAppointmentMgt.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HealthMgt.OnlineAppointmentMgt.dll"]