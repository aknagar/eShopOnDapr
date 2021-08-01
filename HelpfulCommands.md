# initialize dapr in Kubernetes
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