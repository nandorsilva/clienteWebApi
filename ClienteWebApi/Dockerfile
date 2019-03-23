FROM microsoft/dotnet:sdk AS build-env
WORKDIR /app

# Copy everything and build
COPY . ./

RUN dotnet restore "./ClienteWebApi.csproj"
RUN dotnet publish "ClienteWebApi.csproj" -c Release -o out

FROM microsoft/dotnet:aspnetcore-runtime
WORKDIR /app
COPY --from=build-env /app/out .
ENTRYPOINT ["dotnet", "ClienteWebApi.dll"]