FROM mcr.microsoft.com/dotnet/core/aspnet:3.0-buster-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:3.0-buster AS build
WORKDIR /src
COPY ["HealthMgt.InvoiceMgtMicroService/HealthMgt.InvoiceMgtMicroService.csproj", "HealthMgt.InvoiceMgtMicroService/"]
RUN dotnet restore "HealthMgt.InvoiceMgtMicroService/HealthMgt.InvoiceMgtMicroService.csproj"
COPY . .
WORKDIR "/src/HealthMgt.InvoiceMgtMicroService"
RUN dotnet build "HealthMgt.InvoiceMgtMicroService.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "HealthMgt.InvoiceMgtMicroService.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "HealthMgt.InvoiceMgtMicroService.dll"]