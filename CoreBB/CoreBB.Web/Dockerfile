FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["CoreBB.Web/CoreBB.Web.csproj", "CoreBB.Web/"]
RUN dotnet restore "CoreBB.Web/CoreBB.Web.csproj"
COPY . .
WORKDIR "/src/CoreBB.Web"
RUN dotnet build "CoreBB.Web.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "CoreBB.Web.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "CoreBB.Web.dll"]