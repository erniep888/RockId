## Identity Server Creation ##

What is needed?

### Quickstart UI ###

This could be used as a simple Admin tool while in development phase.  Contains a simple starter UI including login, logout and consent pages.

### Access token validation handler ###

This is what service APIs should use to validate tokens.  ASP.NET Core authentication handler for validating tokens in APIs. The handler allows supporting both JWT and reference tokens in the same API.

### Creation Steps ###
```
#!c#

dotnet new -i identityserver4.templates
```
```
#!c#

mkdir HelloFullStack.Identity
```
```
#!c#

cd HelloFullStack.Identity
```
```
#!c#

dotnet new is4aspid
```
Do not run dotnet run /seed
```
#!c#

dotnet add package Microsoft.EntityFrameworkCore --version 2.1.0
```
```
#!c#

dotnet add package Microsoft.EntityFrameworkCore.Design --version 2.1.0
```