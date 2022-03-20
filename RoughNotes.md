### Default credentials
User: alice
Password: Pass@word1

## Local-host

### Build the application
> cd eshopOnDapr/src
>
> docker-compose build

### Run in local Docker host
> docker-compose up

### Health-check UI
* http://localhost:5107
* http://host.docker.internal:5107/hc-ui#/healthchecks

### Homepage SPA application
* http://localhost:5104
* http://host.docker.internal:5104/

### Swagger UI
* http://localhost:5101
* http://host.docker.internal:5101

### Seq: Logs Monitoring
* http://localhost:5340
* http://host.docker.internal:5340

### Zipkin : Latency diagnosis
Zipkin is a distributed tracing system. It helps gather timing data needed to troubleshoot latency problems in service architectures. 
* http://localhost:9411

## Run on Kubernetes
### initialize dapr in Kubernetes 
dapr init -k 

### install Helm
choco install kubernetes-helm -s="https://community.chocolatey.org/api/v2/"

C:\Users\aknagar\source\repos\eShopOnDapr\deploy\k8s\helm> helm install helm install myeshop .

helm uninstall myeshop

http://localhost:30007/healthchecks-ui

### Kubernetes Dashboard

To install the Kubernetes Dashboard, open a PowerShell terminal, and run the following:

kubectl apply -f https://raw.githubusercontent.com/kubernetes/dashboard/v2.2.0/aio/deploy/recommended.yaml

This command downloads the deployment manifest and applies it to your cluster

kubectl get pods --namespace kubernetes-dashboard

https://jpinjpblog.wordpress.com/2020/11/17/adding-kubernetes-dashboard-to-docker-for-desktop-running-kubernetes/

kubectl proxy




### list of containers running in docker
> docker ps

### get all kubernetes pods
> kubectl get pods --all-namespaces

#### set up Startup project is equivalent to changing the directory in terminal
In VS 2019, we select set as Startup project
In vscode, we simply change cwd directory = <folder for startup project> in launch.json

The docker-compose.yml file contains the definition of all the images needed to run eShopOnDapr

The docker-compose.override.yml file contains the base configuration for all images of the previous file.

docker-compose up -- to run containers

### EntityFramework Core
### Generate migration scripts in Migrations project
> dotnet ef migrations add <MigrationName> --startup-project <sourceproject> --project <projectwheretocreateMigration>

#### multiple providers
https://docs.microsoft.com/en-us/ef/core/managing-schemas/migrations/providers?tabs=dotnet-core-cli

### database scaffolding - generating C# code from existing database
https://docs.microsoft.com/en-us/ef/core/managing-schemas/scaffolding?tabs=dotnet-core-cli

> dotnet ef dbcontext scaffold "Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Microsoft.eShopOnContainers.Services.OrderingDb" Microsoft.EntityFrameworkCore.SqlServer --output-dir ./Ordering --context OrderingDbContext

### EF CLI
https://docs.microsoft.com/en-us/ef/core/cli/dotnet

> dotnet ef database drop --dry-run 

> dotnet ef database drop

> dotnet ef database update -- creates new database and applies migration

> dotnet ef database update --connection "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Microsoft.eShopOnContainers.Services.OrderingDb"

> dotnet ef dbcontext info 
	Provider name: Microsoft.EntityFrameworkCore.SqlServer
	Database name: Microsoft.eShopOnContainers.Services.OrderingDb
	Data source: (localdb)\MSSQLLocalDB
	Options: MigrationsAssembly=Ordering.API

> dotnet ef dbcontext list
	Microsoft.eShopOnContainers.Services.Ordering.API.Infrastructure.OrderingContext
	
> dotnet ef dbcontext script -- creates sql schema script based on dbcontext

## References:
1. https://github.com/dotnet-architecture/eShopOnContainers/wiki/Windows-setup
2. 