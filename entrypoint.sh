#!/bin/sh
dotnet build -r linux-x64 -o "/app/bin/Debug/netcoreapp2.1/"
dotnet watch run --no-build --launch-profile "Docker"
# tail -f /dev/null # for debugging
