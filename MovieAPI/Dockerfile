# Build Stage -> building the sdk
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY . . 
RUN dotnet restore "./MovieAPI/MovieAPI.csproj" --disable-parallel
RUN dotnet publish "./MovieAPI/MovieAPI.csproj" -c release -o /app --no-restore

# Serve Stage 
FROM mcr.microsoft.com/dotnet/sdk:6.0
WORKDIR /app 
COPY --from=build /app ./

EXPOSE 5000

ENTRYPOINT ["dotnet", "MovieAPI.dll"]