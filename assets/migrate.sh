#!/bin/bash

COMMANDS=("migrate" "add" "remove")

if [[ ${COMMANDS[*]} =~ ${1} ]]; then
  echo "migrations: please give migrate, add or remove command" || exit 0;
fi

if [[ $1 == "migrate" ]]; then
  dotnet ef database update $2;
fi

if [[ $1 == "add" ]]; then
  dotnet ef migrations add $2;
fi

if [[ $1 == "remove" ]];
  then dotnet ef migrations remove $2;
fi
