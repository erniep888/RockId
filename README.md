RockId
======

Definition
----------

A demonstration application for Feature Driven Development, Angular, IIS, SQL Server, and ASP.NET Core 2 Web API.

- :grey_question: [Purpose](Documents/PURPOSE.md)
- :factory: [Technologies Used](Documents/TECHNOLOGIES.md)
- :notebook_with_decorative_cover: [Features](Documents/FEATURES.md)

  - [Epics - Infrastructure](Documents/EPICS-INFRASTRUCTURE.md)
  - [Epics - User Security](Documents/EPICS-USER_SECURITY.md)
  - [Epics - All Identified Rocks](Documents/EPICS-ALL_ROCKS.md)
  - [Epics - All Action History](Documents/EPICS-ALL_ACTIONS.md)
  - [Epics - Identify Rock](Documents/EPICS-IDENTIFY_ROCK.md)

- :triangular_flag_on_post: [Milestone Plan](Documents/MILESTONES.md)
- :triangular_ruler: [Architecture](Documents/ARCHITECTURE.md)
- :construction_worker: [Implementation](Documents/IMPLEMENTATION.md)

Repository Structure
--------------------

- :memo: [Documents](Documents) - Contains all documentation for the entire application.
- :computer: [Source](Source) - Contains all of the application source code

  - [UI](Source/UI/rock-id) - Contains the user interface implemented in Angular 6
  - [Api](Source/Api) - Contains the ASP.NET Core Web API.
  - Database - Contains the scripts for creating and maintaining the database.
  - [Identity](Source/Identity) - Contains the identity server implementation.

Prerequisite
------------

- [Angular 6](https://angular.io/)
- [ASP.NET Core 2 Web API](https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-2.1)
- [SQL Server 2017](https://docs.microsoft.com/en-us/sql/sql-server/install/planning-a-sql-server-installation?view=sql-server-2017)
- [Identity Server Creation](Documents/IDENTITYSERVERCREATION.md)

Install
-------

- TBD

Build
-------

- TBD

Development Run
---------------

- TBD

Unit Test
---------

- TBD

End-to-End Test
---------------

- TBD

All Tests
---------

- TBD

Version
-------

0.0.2

Language
--------

- [TypeScript 2.7](https://www.typescriptlang.org/)
- [C# .NET Core 2.1](https://docs.microsoft.com/en-us/dotnet/core/)

ChangeLog
---------

- 0.0.2
  - Created features, epics, milestones, and wire frames
- 0.0.1
  - initial creation
