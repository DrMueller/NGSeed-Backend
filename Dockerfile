FROM microsoft/aspnetcore:2.0
WORKDIR /app
COPY ./DockerContent .

ENTRYPOINT ["dotnet", "Mmu.Ngs.WebApi.dll"]