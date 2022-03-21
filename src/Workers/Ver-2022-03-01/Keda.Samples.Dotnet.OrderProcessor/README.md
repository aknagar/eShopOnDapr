Deployment(
https://github.com/aknagar/sample-dotnet-worker-servicebus-queue/blob/main/connection-string-scenario.md)

* Create namespace

kubectl create namespace worker-sample

* Deploy on k8s

kubectl apply -f deploy\k8s\deploy-worker.yaml --namespace worker-sample

* Check deployment 

kubectl get deployments --namespace worker-sample -o wide

* Check pods

kubectl get pods --namespace worker-sample

* Check namespaces

kubectl get namespaces

Run an image in kubectl
kubectl run myapp --image=ghcr.io/aknagar/sample-dotnet-worker-servicebus-queue:latest

kubectl describe pod myapp

https://www.containiq.com/post/kubernetes-imagepullbackoff
