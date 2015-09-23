FROM microsoft/aspnet:1.0.0-beta6

COPY src/. /app/
WORKDIR /app/Hello.Web
ENV MONO_THREADS_PER_CPU=2000
RUN ["dnu", "restore"]
EXPOSE 80
ENTRYPOINT ["dnx", "project.json", "kestrel"]
