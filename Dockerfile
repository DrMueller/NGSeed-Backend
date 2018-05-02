FROM microsoft/aspnetcore-build:latest AS build-env
WORKDIR /app

COPY . ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM microsoft/aspnetcore:2.0
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "Mmu.Ngs.WebApi.dll"]