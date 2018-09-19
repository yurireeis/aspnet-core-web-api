FROM microsoft/dotnet:2.1-sdk

ENV APP_PATH=/app

RUN mkdir ${APP_PATH}

WORKDIR ${APP_PATH}

COPY Program.cs ${APP_PATH}/

COPY AspNetWebApi.csproj ${APP_PATH}/

RUN dotnet restore

ENV DLL_PATH=bin/Debug/netcoreapp2.1

RUN mkdir -p ${APP_PATH}/${DLL_PATH}/

COPY *.cs ${APP_PATH}/

RUN dotnet build -o ${APP_PATH}/${DLL_PATH}/ -r linux-x64

ENTRYPOINT [ "dotnet", "watch", "run" ]
