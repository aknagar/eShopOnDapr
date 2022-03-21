FROM mcr.microsoft.com/dotnet/runtime:6.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src  
# The WORKDIR instruction sets the working directory for any RUN, CMD, ENTRYPOINT, COPY and ADD instructions that follow it in the Dockerfile

# COPY source dest
# COPY source command is relative to the parameter PATH passed in docker build command
# Example docker build ./src/ --file ./src/Workers/Ver-2022-03-01/Keda.Samples.Dotnet.OrderProcessor/Dockerfile --tag worker:latest
# Here relative path starts from /src directory on repo.
# One should also try to maintain the same hierarchy of folders in docker image that is in repo, otherwise ProjectReferences might break.
COPY ["Workers/Ver-2022-03-01/Keda.Samples.Dotnet.OrderProcessor/Keda.Samples.Dotnet.OrderProcessor.csproj", "Workers/Ver-2022-03-01/Keda.Samples.Dotnet.OrderProcessor/"]
COPY ["Keda.Samples.Dotnet.Contracts/Keda.Samples.Dotnet.Contracts.csproj", "Keda.Samples.Dotnet.Contracts/"]
RUN dotnet restore "Workers/Ver-2022-03-01/Keda.Samples.Dotnet.OrderProcessor/Keda.Samples.Dotnet.OrderProcessor.csproj"
COPY . .
WORKDIR "/src/Workers/Ver-2022-03-01/Keda.Samples.Dotnet.OrderProcessor"
RUN dotnet build "Keda.Samples.Dotnet.OrderProcessor.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Keda.Samples.Dotnet.OrderProcessor.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Keda.Samples.Dotnet.OrderProcessor.dll"]