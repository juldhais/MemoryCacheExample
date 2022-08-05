FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["MemoryCacheExample/MemoryCacheExample.csproj", "MemoryCacheExample/"]
RUN dotnet restore "MemoryCacheExample/MemoryCacheExample.csproj"
COPY . .
WORKDIR "/src/MemoryCacheExample"
RUN dotnet build "MemoryCacheExample.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "MemoryCacheExample.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "MemoryCacheExample.dll"]
