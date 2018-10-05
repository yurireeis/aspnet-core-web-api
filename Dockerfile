FROM microsoft/dotnet:2.1-sdk

ENV APP_PATH=app

RUN mkdir "/${APP_PATH}/"

WORKDIR "/${APP_PATH}/"

COPY Program.cs .

COPY Startup.cs .

COPY *.csproj .

COPY global.json .

COPY assets/entrypoint.sh /usr/bin/entrypoint

COPY assets/migrate.sh /usr/bin/migrate

RUN chmod +x /usr/bin/entrypoint

RUN chmod +x /usr/bin/migrate

ENTRYPOINT [ "entrypoint" ]
