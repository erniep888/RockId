FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 90

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR "/src"
COPY ["RockId.BackendForFrontend_Spa.csproj", "./"]
RUN dotnet restore "RockId.BackendForFrontend_Spa.csproj"
COPY . .
RUN dotnet build "RockId.BackendForFrontend_Spa.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "RockId.BackendForFrontend_Spa.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENV ASPNETCORE_URLS=http://+:90
ENTRYPOINT ["dotnet", "RockId.BackendForFrontend_Spa.dll"]