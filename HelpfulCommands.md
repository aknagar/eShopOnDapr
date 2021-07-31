# initialize dapr in Kubernetes
dapr init -k 

# install manifest files on Kubernetes
>kubectl apply -f manifest/

# list of containers running in docker
docker ps

# get all kubernetes pods
kubectl get pods --all-namespaces