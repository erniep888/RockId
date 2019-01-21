FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["Qarp/Qarp.GlassyRock/Qarp.GlassyRock.csproj", "Qarp/Qarp.GlassyRock/"]
RUN dotnet restore "Qarp/Qarp.GlassyRock/Qarp.GlassyRock.csproj"
COPY . .
WORKDIR "/src/Qarp/Qarp.GlassyRock"
RUN dotnet build "Qarp.GlassyRock.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Qarp.GlassyRock.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Qarp.GlassyRock.dll"]