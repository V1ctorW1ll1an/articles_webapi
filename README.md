# Importante

Projeto com unico intuito de ser para o meu aprendizado

## Instalação

Download das ferramentas nos sites

[dotnet-framework] https://dotnet.microsoft.com/download/dotnet-framework
[PostgreSql] https://www.postgresql.org/download/
[PgAdmin] https://www.pgadmin.org/download/
[Cmder] https://cmder.net/

## Criar os projetos

### Criar Solução

```bash
    $ dotnet new sln
```

### Criar API

```bash
    $ dotnet new webapi -o ArticlesWeb
```

### Criar camada de dados

```bash
    $ dotnet new classlib -f netcoreapp3.1 -o ArticlesData
```

### Criar camada de services

```bash
    $ dotnet new classlib -f netcoreapp3.1 -o ArticlesServices
```

### Criar camada de testes

```bash
    $ dotnet new xunit -o ArticlesTest
```

### Adicionar Camadas à solução

```bash
    $ dotnet sln add <nome_da_camada>
```

# uso

```
    $ git checkout develop
```

## Dependencias backend

```bash
    $ dotnet add package EntityFramework --version 6.4.0
    $ dotnet add package Microsoft.EntityFrameworkCore.Tools
    $ dotnet add package Microsoft.EntityFrameworkCore.Design
    $ dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL
    $ dotnet add package Npgsql.EntityFrameworkCore.PostgreSQL.Design
    $ dotnet add package AutoMapper
    $ dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
    $ dotnet tool install --global dotnet-ef
    $ dotnet add reference ..\GoodBooksData\GoodBooksData.csproj
    $ dotnet add ./GoodBooksWeb/GooBooksWeb.csproj package Newtonsoft.Json
```

### Fique a vontade para pull requests
