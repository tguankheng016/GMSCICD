FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build

WORKDIR /src
COPY ["src/GMS.Web.Host/GMS.Web.Host.csproj", "src/GMS.Web.Host/"]
COPY ["src/GMS.Web.Core/GMS.Web.Core.csproj", "src/GMS.Web.Core/"]
COPY ["src/GMS.Application/GMS.Application.csproj", "src/GMS.Application/"]
COPY ["src/GMS.Core/GMS.Core.csproj", "src/GMS.Core/"]
COPY ["src/GMS.EntityFrameworkCore/GMS.EntityFrameworkCore.csproj", "src/GMS.EntityFrameworkCore/"]
WORKDIR "/src/src/GMS.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/GMS.Web.Host", "src/GMS.Web.Host"]
COPY ["src/GMS.Web.Core", "src/GMS.Web.Core"]
COPY ["src/GMS.Application", "src/GMS.Application"]
COPY ["src/GMS.Core", "src/GMS.Core"]
COPY ["src/GMS.EntityFrameworkCore", "src/GMS.EntityFrameworkCore"]
WORKDIR "/src/src/GMS.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:7.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "GMS.Web.Host.dll"]
