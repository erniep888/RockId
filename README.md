RockId
======

Definition
----------

A demonstration application for [Feature Driven Development](http://agilemodeling.com/essays/fdd.htm), [Microservice Architecture](https://docs.microsoft.com/en-us/dotnet/standard/microservices-architecture/), [Angular](https://angular.io/), [SQL Server 2017 on Linux](https://docs.microsoft.com/en-us/sql/linux/sql-server-linux-overview?view=sql-server-2017), and [ASP.NET Core 2 Web API](https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-2.2).

- :grey_question: [Purpose](Documents/PURPOSE.md)
- :globe_with_meridians: [Technologies Used](Documents/TECHNOLOGIES.md)
- :page_with_curl: [Features](Documents/FEATURES.md)
  - [Epics - Research](Documents/EPICS-RESEARCH.md)
  - [Epics - User Security](Documents/EPICS-USER_SECURITY.md)
  - [Epics - All Identified Rocks](Documents/EPICS-ALL_ROCKS.md)
  - [Epics - Event Logger](Documents/EPICS-EVENT_LOGGER.md)
  - [Epics - Identify Rock](Documents/EPICS-IDENTIFY_ROCK.md)

- :triangular_flag_on_post: [Milestone Plan](Documents/MILESTONES.md)
- :triangular_ruler: [Architecture](Documents/ARCHITECTURE.md)
- :construction_worker: [Implementation](Documents/IMPLEMENTATION.md)

Project Structure
-----------------

- :memo: [Documents](Documents) - Contains all documentation for the entire application.
- :computer: [Source](Source) - Contains all of the application source code

  - [UI](Source/UI/rock-id) - Contains the user interface implemented in Angular 7
  - [Api Gateway](Source/ApiGateway) - Contains the API Gateway that enables a single entry point for all api calls to the backend among other [benefits](https://microservices.io/patterns/apigateway.html).
  - [Service - QARP Glassy Rock](Source/Service/QARP/GlassyRock) - Contains the microservice api that leverages QARP to identify glassy rock types.
  - [Service - Identified Rock](Source/Service/IdentifiedRock) - Contains the microservice api that allows identified rocks to be searched, edited, and removed.
  - [Service - Event Logger](Source/Service/EventLogger) - Contains the microservice api that allows all other services to log specific events and actions.
  - [Service - Identity](Source/Service/Identity) - This microservice is an identity provider implemented with IdentityServer 4.
  - [EventBus](Source/BuildingBlock/EventBus) - Contains an event bus that leverages RabbitMQ in order to allow services to communicate in a loosely coupled manner.  

Prerequisite
------------

- [Angular 7](https://angular.io/)
- [ASP.NET Core 2.2 Web API](https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-2.2)
- [Visual Studio 2017](https://visualstudio.microsoft.com/vs/)
- [Docker Desktop](https://www.docker.com/products/docker-desktop)

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

- SUT is System Under Test
- xunit, Moq, and AutoFixture are used to provide a testing framework, an injection framework, and a mock data framework respectively.

End-to-End Test
---------------

- TBD

All Tests
---------

- TBD

Version
-------

0.0.3

Language
--------

- [TypeScript 2.7](https://www.typescriptlang.org/)
- [C# 7.3](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7-3)

ChangeLog
---------

- 0.0.3
  - Switching to a Docker Container development and deployment approach
- 0.0.2
  - Created features, epics, milestones, and wire frames
- 0.0.1
  - initial creation
