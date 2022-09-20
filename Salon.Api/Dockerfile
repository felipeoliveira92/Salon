#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Salon.Api/Salon.Api.csproj", "Salon.Api/"]
COPY ["Salon.Service/Salon.Service.csproj", "Salon.Service/"]
COPY ["Salon.Model/Salon.Model.csproj", "Salon.Model/"]
COPY ["Salon.Infra/Salon.Infra.csproj", "Salon.Infra/"]
RUN dotnet restore "Salon.Api/Salon.Api.csproj"
COPY . .
WORKDIR "/src/Salon.Api"
RUN dotnet build "Salon.Api.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Salon.Api.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Salon.Api.dll"]