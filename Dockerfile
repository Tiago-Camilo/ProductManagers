# Etapa 1: Compilação
FROM mcr.microsoft.com/dotnet/sdk:10.0 AS build

WORKDIR /src

COPY ["ProductManagers/ProductManagers.csproj", "ProductManagers/"]

RUN dotnet restore "ProductManagers/ProductManagers.csproj"

COPY . .

WORKDIR /src/ProductManagers

RUN dotnet publish "ProductManagers.csproj" \
    -c Release \
    -o /app/publish \
    /p:UseAppHost=false

# Etapa 2: Execução
FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS final

WORKDIR /app

COPY --from=build /app/publish .

ENV ASPNETCORE_URLS=http://+:8080
ENV ASPNETCORE_ENVIRONMENT=Production

EXPOSE 8080

ENTRYPOINT ["dotnet", "ProductManagers.dll"]