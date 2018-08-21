FROM microsoft/dotnet:2.1-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 63002
EXPOSE 44349

FROM microsoft/dotnet:2.1-sdk AS build
WORKDIR /src
COPY GoddadyApiImplementation.Api/GoddadyApiImplementation.Api.csproj GoddadyApiImplementation.Api/
COPY GoddadyApiImplementation.Infrastructure/GoddadyApiImplementation.Infrastructure.csproj GoddadyApiImplementation.Infrastructure/
COPY GoddadyApiImplementation.Service/GoddadyApiImplementation.Service.csproj GoddadyApiImplementation.Service/
COPY GoddadyApiImplementation.Domains/GoddadyApiImplementation.Domains.csproj GoddadyApiImplementation.Domains/
COPY GoddadyApiImplementation.Shared/GoddadyApiImplementation.Shared.csproj GoddadyApiImplementation.Shared/
RUN dotnet restore GoddadyApiImplementation.Api/GoddadyApiImplementation.Api.csproj
COPY . .
WORKDIR /src/GoddadyApiImplementation.Api
RUN dotnet build GoddadyApiImplementation.Api.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish GoddadyApiImplementation.Api.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "GoddadyApiImplementation.Api.dll"]
