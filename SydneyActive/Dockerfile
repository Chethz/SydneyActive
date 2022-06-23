#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SydneyActive/SydneyActive.csproj", "SydneyActive/"]
RUN dotnet restore "SydneyActive/SydneyActive.csproj"
COPY . .
WORKDIR "/src/SydneyActive"
RUN dotnet build "SydneyActive.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SydneyActive.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SydneyActive.dll"]
