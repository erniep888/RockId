# Identity Server Creation #

What is needed?

## Quick Start UI ##

This could be used as a simple Admin tool while in development phase.  Contains a simple starter UI including login, logout and consent pages.

## Access token validation handler ##

This is what service APIs should use to validate tokens.  ASP.NET Core authentication handler for validating tokens in APIs. The handler allows supporting both JWT and reference tokens in the same API.

## Creation Steps ##

``` csharp
dotnet new -i identityserver4.templates
```

``` csharp
mkdir Source\Identity
```

``` csharp
cd Source\Identity
```

``` csharp
dotnet new is4aspid
```

Do not run dotnet run /seed

``` csharp
dotnet add package Microsoft.EntityFrameworkCore --version 2.1.0
```

``` csharp
dotnet add package Microsoft.EntityFrameworkCore.Design --version 2.1.0
```