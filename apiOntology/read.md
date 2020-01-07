#run 

## Use Visual Studio 

or 

## Use Docker
docker run --rm -it -v ${PWD}:/opt/api -w /opt/api mcr.microsoft.com/dotnet/core/sdk
dotnet publish
dotnet /opt/api/bin/Debug/netcoreapp3.0/publish/apiOntology.dll

#Open DOTNET Bash
docker run --name postgres -v /my/own/datadir:/var/lib/postgresql/data -d postgres
docker run -d postgres
docker exec -it 5ecada5aa92 bash

#Database
##Install
dotnet tool install dotnet-ef -g

##Create a database with the context of the application
dotnet ef database update

#other useful commands
#find ip
Docker ps
Docker inspect 0a0

