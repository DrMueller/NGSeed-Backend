FROM microsoft/aspnetcore:2.0
WORKDIR /app
COPY . .
EXPOSE 80
ENTRYPOINT ["dotnet", "Mmu.Ngs.WebApi.dll"]