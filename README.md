# Portfolio
Template for Net 7 framework with PostgreSQL database
## Добавление пакетов NuGet
Пакет NuGet необходимо добавить для поддержки базы данных, используемой в этом руководстве.
+ В меню Средства выберите Диспетчер пакетов NuGet > Управление пакетами NuGet для решения.
+ Откройте вкладку Browse (Обзор).
+ Установите флажок Включить предварительные выпуски.
+ Введите название пакета в поле поиска и щелкните.
+ Установите флажок Проект в области справа и выберите Установить.
```
Microsoft.EntityFrameworkCore.InMemory
```
```
Microsoft.EntityFrameworkCore.SqlServer
```
```
Npgsql.EntityFrameworkCore.PostgreSQL 
```
```
Swashbuckle.AspNetCore
``````
## Предварительная настройка

1. Установите `dotnet-ef`, для этого откройте консоль диспетчера пакетов, вставьте и выполните следующую команду:

```
  dotnet tool install --global dotnet-ef
```

## Создание БД с помощью CLI

1. Запустите сборку проекта:

```
  dotnet build
```

2. Запустите команду на создание миграции

```
  dotnet ef migrations add InitialCreate
```

3. Обновите БД

```
  dotnet ef database update
```
