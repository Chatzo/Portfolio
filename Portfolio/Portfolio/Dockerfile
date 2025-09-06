# Build steg: bygger projektet med .NET 8 SDK
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app

# Kopiera hela projektmappen
COPY . ./Portfolio

# Byt arbetsmapp till där csproj ligger
WORKDIR /app/Portfolio

# Återställ dependencies för Portfolio.csproj
RUN dotnet restore Portfolio.csproj

# Builda projektet
RUN dotnet publish -c Release -o out Portfolio.csproj

# Runtime steg: kör appen i lättviktsbild
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Kopiera byggda filer från build-steget
COPY --from=build /app/Portfolio/out ./

# Exponera porten appen använder
EXPOSE 5000

# Starta appen
ENTRYPOINT ["dotnet", "Portfolio.dll"]
