# RockId #

## Definition ##

A demonstration application for [Feature Driven Development](http://agilemodeling.com/essays/fdd.htm), [Microservice Architecture](https://docs.microsoft.com/en-us/dotnet/standard/microservices-architecture/), [Angular](https://angular.io/), [SQL Server 2017 on Linux](https://docs.microsoft.com/en-us/sql/linux/sql-server-linux-overview?view=sql-server-2017), and [ASP.NET Core 2 Web API](https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-2.2).

The application is called RockId.  It allows a person to identify a rock based on responses to a series of questions and answers.  Each identified rock is placed in a rock collection where more information can be associated with the rock.  All significant events can be viewed by all users and all identified rocks can be viewed by all users.

My team uses this application to brainstorm and share ideas before committing to architectural strategies for large applications that actually have significant personnel or monetary impact.  Anyone that reads this should feel free to clone, change, and contribute ideas for new approaches and/or technological solutions.

---------------------------------------

## Index ##

- :open_file_folder: [Project Structure](#project-structure)
- :memo: [Requirements](#requirements)
- :straight_ruler: [Features Based On Requirements](#features-based-on-requirements)
  - [Epics - Research](Documents/EPICS-RESEARCH.md)
  - [Epics - User Security](Documents/EPICS-USER_SECURITY.md)
  - [Epics - Rock Collection](Documents/EPICS-ROCK_COLLECTION.md)
  - [Epics - Event Logger](Documents/EPICS-EVENT_LOGGER.md)
  - [Epics - Identify Rock](Documents/EPICS-IDENTIFY_ROCK.md)

- :triangular_flag_on_post: [Milestone Plan](#milestone-plan)
- :construction_worker: [Implementation](#implementation)
- :computer: [Development](#development)

---------------------------------------

## Project Structure ##

- [Documents](Documents) - Contains all documentation for the entire application.
- [Source](Source) - Contains all of the application source code

  - [UI](Source/UI/rock-id) - Contains the user interface implemented in Angular 7
  - [Api Gateway](Source/ApiGateway) - Contains the API Gateway that enables a single entry point for all api calls to the backend among other [benefits](https://microservices.io/patterns/apigateway.html).
  - [Service - QARP Glassy Rock](Source/Service/Qarp/Qarp.GlassyRock) - Contains the microservice api that leverages QARP to identify glassy rock types.
  - [Service - Identified Rock](Source/Service/IdentifiedRock) - Contains the microservice api that allows identified rocks to be searched, edited, and removed.
  - [Service - Event Logger](Source/Service/EventLogger) - Contains the microservice api that allows all other services to log specific events and actions.
  - [Service - Identity](Source/Service/Identity) - This microservice is an identity provider implemented with IdentityServer 4.
  - [EventBus](Source/BuildingBlock/EventBus) - Contains an event bus that leverages RabbitMQ in order to allow services to communicate in a loosely coupled manner.  

---------------------------------------

## Requirements ##

1. Allow a user to login.
2. Display all the rocks that have been identified for and by all users.
3. Display the history of all actions within the application (complete list follows):
      * Rock identified
      * User added
      * User logged in
4. The user landing page should be a dashboard that contains:
      * My Rock Identification Count
      * Total Rock Identification Count
5. Identity Rock - allows a user to create a new rock identification.
6. Search all identified rocks:
      * Show me a count of rocks that are igneous, metamorphic, or sedimentary.

---------------------------------------

## Features Based On Requirements ##

1. User Security
   * ***Detail:*** All users must be known to the system.
   * ***Solution:***
     * Anonymous user access is denied.
     * All users must login in with an email address
     * All users have a password that is 8 to 32 characters long and alphanumeric with special characters.
2. Display All Rocks Identified
   * ***Detail:*** All rocks that have been identified should be visible to all other authenticated users.
   * ***Solution:***
     * Once a rock has been successfully identified, it will be displayed in a list displayed in the order of completion date.
     * All identified rocks will be displayed in one page.
3. Display All Action History
   * ***Detail:*** All actions are tracked and displayed for all authenticated users.
   * ***Solution:***
     * The following actions are tracked:
       * Login
       * Logout
       * Rock identified
       * User added
     * All actions will be displayed in one page.
4. Identify Rock
   * ***Detail:*** An authenticated user can step through the process to identify a rock.
   * ***Solution:***
     * For 1.0, this feature only implements identification of glassy and fine-grained rocks. The authenticated user will answer questions to identity the rock.
     * What is the grain size?
       * Glassy (no visible grains)
         * Is it light or dark?
           * Light is Igneous - Quartz.
           * Dark is Igneous - Obsidian
       * Fine Grained (not easy to see grains)
         * Can the rock be scratched by a knife?
           * Yes, and it is dense and brittle - Sedimentary - Chert.
           * No
             * Is it light in color?
               * Yes, with glossy grains - Metamorphic - Quartzite.
               * Yes, with dull grains - Igneous - Felsite.
               * No
                 * Is it medium in color?
                   * Yes - Igneous - Andesite.
                   * No - It is dark in color.
                     * Does it fizz with acid?
                       * Yes, vigorously - Sedimentary - Limestone.
                       * Yes, with difficulty or with rock powder - Sedimentary - Dolomite.
                       * No
                         * Does it have layers?
                           * Yes, it splits easily into thin smooth sheets - Metamorphic - Slate
                           * Yes, it does not split easily - Metamorphic - Shale
                           * No, it does have slippery feel colored green to black - Metamorphic - Serpentine
       * Mixed Fine and Coarse
         * Not in release 1.0
       * Medium to Coarse
         * Not in release 1.0

---------------------------------------

## Milestone Plan ##

| Milestone | Feature | Target | Delivered | Status | Notes
|--|--|--|--|--|--|
|M1  :checkered_flag: |  |  09-30-2018  | 10-05-2018 |  | Research kickoff
||[Research](Documents/EPICS-RESEARCH.md)| | |45%| :heavy_check_mark: #7, :heavy_check_mark: #8, :heavy_check_mark: #37
|M2 :checkered_flag: |  |  10-15-2018  | 10-22-2018 |  | Initial UI
||[Research](Documents/EPICS-RESEARCH.md)| | |50%| :heavy_check_mark: #9, :heavy_check_mark: #10, :heavy_check_mark: #13
||[Identify Rock](Documents/EPICS-IDENTIFY_ROCK.md)  | | |10%| :heavy_check_mark: #17, :heavy_check_mark: #19
|M3 :runner:|  |  01-25-2019  |  |  | Create the Event Logger microservice
||[Event Logger](Documents/EPICS-EVENT_LOGGER.md)  | | |30%| :runner: #15
|M4 :zzz:|  |  02-02-2019  |  |  | Capable of storing data
||[Research](Documents/EPICS-RESEARCH.md) | | |100%| #11, #12, #18
||[Identify Rock](Documents/EPICS-IDENTIFY_ROCK.md)  | | |30%| #20, #21
||[Event Logger](Documents/EPICS-EVENT_LOGGER.md)  | | |40%| #35
|M5 :zzz:|  |	02-17-2019	|  |  | User security
||[User Security](Documents/EPICS-USER_SECURITY.md) |  | |100%| #6, #5, #1, #2, #3, #4
|M6 :zzz:|  |	03-01-2019	|  |  | Identify rocks
||[Identify Rock](Documents/EPICS-IDENTIFY_ROCK.md)  |  | |80%| #22, #23, #24, #25, #26, #27
||[Event Logger](Documents/EPICS-EVENT_LOGGER.md)  |  | |90%| #16, #32, #33, #34
|M7 :zzz:|  |	03-15-2019	|  |  | Display identified rocks
||[Rock Collection](Documents/EPICS-ROCK_COLLECTION.md)  |  | |100%| #14, #36
||[Identify Rock](Documents/EPICS-IDENTIFY_ROCK.md)  |  | |100%| #28, #29, #30, #31
||[Event Logger](Documents/EPICS-EVENT_LOGGER.md)  |  | |100%| #35

---------------------------------------

## Implementation ##

### Microservice Images ###
* [sql-qarp](https://cloud.docker.com/repository/docker/erniep888/sql-qarp) - provides the development sql server 2017 database server for the [QARP](Documents/QARP.md) microservices.  Each microservice uses its own database on the server.

### Functional Grouping ###

The primary functions of RockId are _Rock Identification_, _Rock Collection Management_, _Event Logging_, and _User Security_.

### Service Application Layers ###

1. Controller
   * This provides the web api controllers that respond to requests for the service.
2. Dto
   * Provides the data transfer objects that are used when the model object is not sufficient.  
3. Domain
   * Contains the data model and services that are invariant of use cases.  
4. Infrastructure
   * Contains the ORM, external web services, security API, logging, tracing, IoC containers, email, caching, etc.

### Concepts ###

* [QARP](Documents/QARP.md) - QARP stands for the **Q**uestion, **A**nswer, and **R**esult **P**rocess that is used to identify a rock specimen. 

---------------------------------------

## Development ##

### Prerequisites ###

* [Angular 7](https://angular.io/)
* [ASP.NET Core 2.2 Web API](https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-2.2)
* [Visual Studio 2017](https://visualstudio.microsoft.com/vs/)
* [Docker Desktop](https://www.docker.com/products/docker-desktop)

### Installation Steps ###

* TBD - Once the application is capable of identifying a rock, this needs to be completed.

### Build ###

* SQL Server development Docker image 
  * username: ```sa```
  * password: ```Mypasswordis1234```
  * ```Docker
    docker run --name sql-qarp-20190118.2 -d -p 1434:1433 erniep888/sql-qarp
    ```
  * Or, create an empty SQL Server image and add databases using RockId scripts
    ```Docker
    docker run -e "ACCEPT_EULA=Y" -e "SA_PASSWORD=MYpasswordis1234 -p 1434:1433 --name sql-qarp-20190118.2s -d mcr.microsoft.com/mssql/server:2017-latest
    ```
* Event Logger - RabbitMQ Docker image
  * ```Docker
    docker run -d --hostname rockid-mq --name rockid-mq -p 5672:5672 -p 8080:15672 rabbitmq:3-management
    ```
  * From the PackageManager Console run the following:    
    ```Powershell
    EntityFrameworkCore\Add-Migration InitialCreate -StartupProject EventLogger
    ```
    ```Powershell
    EntityFrameworkCore\Update-Database -StartupProject EventLogger
    ```    

### Development Run ###

* TBD - Once the application is capable of identifying a rock, this needs to be completed.

### Unit Test ###

* SUT is System Under Test
* xunit, Moq, and AutoFixture are used to provide a testing framework, an injection framework, and a mock data framework respectively.

### End-to-End Test ###

* TBD - Once the application is capable of identifying a rock, this needs to be completed.

### All Tests ###

* TBD - Once the application is capable of identifying a rock, this needs to be completed.

### Version ###

0.0.3

### Languages ###

* [TypeScript 2.7](https://www.typescriptlang.org/)
* [C# 7.3](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7-3)

### ChangeLog ###

* 0.0.3
  * Switching to a Docker Container development and deployment approach
* 0.0.2
  * Created features, epics, milestones, and wire frames
* 0.0.1
  * initial creation
