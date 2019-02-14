FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 8100

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR "/src"
COPY ["Qarp.GlassyRock.csproj", "./"]
RUN dotnet restore "Qarp.GlassyRock.csproj"
COPY . .
RUN dotnet build "Qarp.GlassyRock.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Qarp.GlassyRock.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENV ASPNETCORE_URLS=http://+:8100
ENTRYPOINT ["dotnet", "Qarp.GlassyRock.dll"]