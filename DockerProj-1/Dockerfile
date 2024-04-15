From mcr.microsoft.com/dotnet/sdk:7.0 As build-env
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./
RUN dotnet publish -c Release -o out

From mcr.microsoft.com/dotnet/aspnet:7.0
WORKDIR /app
EXPOSE 80

COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet","DockerProj-1.dll"]