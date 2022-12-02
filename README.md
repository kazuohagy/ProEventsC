## Comandos iniciais para rodar o programa .NET

E necessario rodar esses comandos no terminal:

```
dotnet tool install --global dotnet-ef
```

Create migrations

```
dotnet ef migrations add Initial -o Data/Migrations
```

Para remover migration

```
dotnet ef migrations remove
```

Para criar um banco de dados SQLITE

```
dotnet ef database update
```
