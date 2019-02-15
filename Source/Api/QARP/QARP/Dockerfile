FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 8100

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR "/src"
COPY ["QARP.csproj", "./"]
RUN dotnet restore "QARP.csproj"
COPY . .
RUN dotnet build "QARP.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "QARP.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENV ASPNETCORE_URLS=http://+:8100
ENTRYPOINT ["dotnet", "QARP.dll"]