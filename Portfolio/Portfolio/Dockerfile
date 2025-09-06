# Build steg: bygger projektet med .NET 8 SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Kopiera .csproj och återställ dependencies
COPY Portfolio.csproj ./
RUN dotnet restore

# Kopiera resten av koden och builda
COPY . ./
RUN dotnet publish -c Release -o out

# Runtime steg: kör appen i lättviktsbild
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Kopiera byggda filer från build-steget
COPY --from=build /app/out .

# Exponera porten appen använder
EXPOSE 5000

# Starta appen
ENTRYPOINT ["dotnet", "Portfolio.dll"]]