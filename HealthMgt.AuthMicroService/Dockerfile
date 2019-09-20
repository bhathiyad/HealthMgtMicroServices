FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY ["HealthMgt.AuthMicroService/HealthMgt.AuthMicroService.csproj", "HealthMgt.AuthMicroService/"]
RUN dotnet restore "HealthMgt.AuthMicroService/HealthMgt.AuthMicroService.csproj"
COPY . .
WORKDIR "/src/HealthMgt.AuthMicroService"
RUN dotnet build "HealthMgt.AuthMicroService.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "HealthMgt.AuthMicroService.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "HealthMgt.AuthMicroService.dll"]