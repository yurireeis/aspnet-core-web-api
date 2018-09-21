#!/bin/sh
VERSION=$(dotnet --list-sdks |grep -oP '(\d+)\.(\d+)\.(\d+)')
dotnet new globaljson --sdk-version "${VERSION}" --force
dotnet build -o "./${DLL_PATH}/" -r linux-x64
dotnet watch run --launch-profile "Docker" "./${DLL_PATH}/AspNetWebApi.dll"
# tail -f /dev/null # for debugging
