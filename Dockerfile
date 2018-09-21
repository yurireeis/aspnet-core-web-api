FROM microsoft/dotnet:2.1-sdk

ENV APP_PATH=app

RUN mkdir "/${APP_PATH}/"

WORKDIR "/${APP_PATH}/"

COPY entrypoint.sh /usr/bin/entrypoint.sh

RUN chmod +x /usr/bin/entrypoint.sh

ENTRYPOINT [ "entrypoint.sh" ]
