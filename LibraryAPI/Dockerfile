# Use the official ASP.NET Core runtime image as a base
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 80

# Use the official ASP.NET Core SDK image to build the app
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src
COPY ["LibraryAPI.csproj", "./"]
RUN dotnet restore "./LibraryAPI.csproj"
COPY . .
WORKDIR "/src"
RUN dotnet build "LibraryAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "LibraryAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "LibraryAPI.dll"]
