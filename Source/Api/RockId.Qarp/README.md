# Starting From Scratch #

## Create ## 

```shell
dotnet new webapi -n RockId.Qarp.Api
```

```shell
dotnet new classlib -n RockId.Qarp.DataMapper
cd RockId.Qarp.DataMapper
rm .\Class1.cs
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add reference ..\..\..\Common\RockId.Common\RockId.Common.csproj
dotnet ef dbcontext scaffold "Data Source=localhost;Initial Catalog=rockid_qarp;Persist Security Info=True;User ID=rockid;Password=rockid123" Microsoft.EntityFrameworkCore.SqlServer
```

```shell
dotnet new sln RockId.Qarp
dotnet sln RockId.Qarp.sln add .\RockId.Qarp.Api\RockId.Qarp.Api.csproj .\RockId.Qarp.DataMapper\RockId.Qarp.DataMapper.csproj
dotnet sln RockId.Qarp.sln add ..\..\Common\RockId.Common\RockId.Common.csproj
```

## Migration Setup ##

```shell
cd RockId.Qarp.DataMapper
dotnet ef migrations add InitialCreate -v
```