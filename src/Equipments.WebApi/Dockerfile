FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Equipments.WebApi/Equipments.WebApi.csproj", "src/Equipments.WebApi/"]
COPY ["src/Equipments..Infrastructure/Equipments.Infrastructure.csproj", "src/Equipments..Infrastructure/"]
COPY ["src/Equipments.Domain/Equipments.Domain.csproj", "src/Equipments.Domain/"]
COPY ["src/Equipments.Application/Equipments.Application.csproj", "src/Equipments.Application/"]
RUN dotnet restore "src/Equipments.WebApi/Equipments.WebApi.csproj"
COPY . .
WORKDIR "/src/src/Equipments.WebApi"
RUN dotnet build "Equipments.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Equipments.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Equipments.WebApi.dll"]