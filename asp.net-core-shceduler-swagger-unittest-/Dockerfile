#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["asp.net-core-shceduler-swagger-unittest-/asp.net-core-shceduler-swagger-unittest-.csproj", "asp.net-core-shceduler-swagger-unittest-/"]
RUN dotnet restore "asp.net-core-shceduler-swagger-unittest-/asp.net-core-shceduler-swagger-unittest-.csproj"
COPY . .
WORKDIR "/src/asp.net-core-shceduler-swagger-unittest-"
RUN dotnet build "asp.net-core-shceduler-swagger-unittest-.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "asp.net-core-shceduler-swagger-unittest-.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "asp.net-core-shceduler-swagger-unittest-.dll"]
