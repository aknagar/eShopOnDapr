### Default credentials
User: demouser@microsoft.com
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


## References:
1. https://github.com/dotnet-architecture/eShopOnContainers/wiki/Windows-setup
2. 



initialize dapr in Kubernetes 
dapr init -k 

# install manifest files on Kubernetes
>kubectl apply -f manifest/

# list of containers running in docker
docker ps

# get all kubernetes pods
kubectl get pods --all-namespaces

# set up Startup project is equivalent to changing the directory in terminal
# In VS 2019, we select set as Startup project
# in vscode, we simply change cwd directory = <folder for startup project> in launch.json

The docker-compose.yml file contains the definition of all the images needed to run eShopOnDapr

The docker-compose.override.yml file contains the base configuration for all images of the previous file.

docker-compose up -- to run containers