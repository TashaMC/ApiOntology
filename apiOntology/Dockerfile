FROM mcr.microsoft.com/dotnet/core/sdk:latest AS build-env
WORKDIR /apiOntology

# Copy csproj and restore as distinct layers
COPY *.csproj ./
RUN dotnet restore

# Copy everything else and build
COPY . ./
RUN dotnet publish -c Release -o out

# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:latest
WORKDIR /apiOntology
COPY --from=build-env /apiOntology/out .
ENTRYPOINT ["dotnet", "/apiOntology.dll"]