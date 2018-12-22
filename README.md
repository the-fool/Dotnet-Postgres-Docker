# Dotnet Core | Postgres | Docker | Angular

An _eazy-peazy_ template for building a Dotnet Core app with Postgres.

## To Run

The only requirement is [Docker Compose](https://docs.docker.com/compose/).

Clone the repo:

```bash
git clone https://github.com/the-fool/dotnet-postgres-docker
cd dotnet-postgres-docker
docker-compose up
```

Navigate to `localhost:4200` for the Angular web client.  Explore your Backend API at `localhost:5000`

Fin!

## How is this so easy?

Docker-Compose takes care of installing the Dotnet runtime, a PostgreSQL server, and NodeJS all in separate, disposable **containers**.  You don't need to worry about installing this software by hand, nor should you worry about mucking up existing versions of these programs on your OS.
