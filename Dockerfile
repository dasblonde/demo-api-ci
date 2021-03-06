FROM microsoft/dotnet:2.1-aspnetcore-runtime-alpine AS base
WORKDIR /app
EXPOSE 80

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY WebApi.csproj src/WebApi/
RUN dotnet restore src/WebApi/WebApi.csproj
WORKDIR /src/src/WebApi
COPY . .
RUN dotnet build WebApi.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish WebApi.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "WebApi.dll"]
