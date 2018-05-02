FROM microsoft/aspnetcore:2.0
WORKDIR /app
COPY /publish /app
ENTRYPOINT ["dotnet", "/app/Mmu.Ngs.WebApi.dll"]