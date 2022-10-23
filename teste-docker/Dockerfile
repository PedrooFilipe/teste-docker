FROM  mcr.microsoft.com/dotnet/sdk:5.0-alpine as builder
ARG CONFIG=Debug

WORKDIR /app

COPY . .

RUN dotnet publish -c $CONFIG

FROM  mcr.microsoft.com/dotnet/aspnet:5.0 as runtime

WORKDIR /app

COPY --from=builder /app/bin/Debug/net5.0/publish .

EXPOSE 80

ENTRYPOINT ["dotnet", "teste-docker.dll"]