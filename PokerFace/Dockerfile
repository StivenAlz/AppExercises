FROM mcr.microsoft.com/dotnet/aspnet:10.0 AS base
WORKDIR /app
EXPOSE 5602

COPY ./bin/Release/net10.0/linux-x64/ .
ENTRYPOINT ["dotnet", "Pokerface.dll"]