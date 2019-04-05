# RockId #

## Definition ##

A demonstration application for [Feature Driven Development](http://agilemodeling.com/essays/fdd.htm), [Microservice Architecture](https://docs.microsoft.com/en-us/dotnet/standard/microservices-architecture/), [Angular](https://angular.io/), [SQL Server Express 2017](https://www.microsoft.com/en-us/sql-server/sql-server-editions-express), and [ASP.NET Core 2 Web API](https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-2.2).

The application is called RockId.  It allows a person to identify a rock based on responses to a series of questions and answers.  Each identified rock is placed in a rock collection where more information can be associated with the rock.  All significant events can be viewed by all users and all identified rocks can be viewed by all users.

This project is intended for brainstorming and sharing design ideas before committing to architectural strategies involving large applications that actually have significant costs associated.  Anyone that reads this should feel free to clone, change, and contribute ideas for new approaches or technological solutions.

---------------------------------------

## Deployment Architecture ##

* [Deployment Architecture](Documents/architecture/Development-Deployment.pdf)

---------------------------------------

## Wireframes ##

* [Login](Documents/wireframe-png/Login.png)
* [Dashboard](Documents/wireframe-png/Dashboard.png)
* [Identify Rock - Grain Size?](Documents/wireframe-png/Identify_Rock-GrainSize.png)
* [Identify Rock - Does it Scratch?](Documents/wireframe-png/Identify_Rock-Scratched.png)
* [Identify Rock - Light Color?](Documents/wireframe-png/Identify_Rock-LightColor.png)
* [Identify Rock - Felsite](Documents/wireframe-png/Identify_Rock-Felsite.png)
* [Rocks](Documents/wireframe-png/Rocks.png)
* [Events](Documents/wireframe-png/Events.png)

---------------------------------------

## Screenshots ##

* [Identify New Rock](Documents/screenshots/IdentifyNewRock-0.3.0.png)

---------------------------------------

## Project Structure ##

- [Documents](Documents) - Contains all documentation for the entire application.
- [Source](Source) - Contains all of the application source code

  - [UI](Source/UI/rock-id) - Contains the user interface implemented in Angular 7
  - [Api Gateway](Source/ApiGateway) - Contains the [Ocelot](http://threemammals.com/ocelot) API Gateway that enables a single entry point for all api calls to the backend among other [benefits](https://microservices.io/patterns/apigateway.html).
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

1. ***User Security***
   * **Detail:** All users must be known to the system.
   * **Solution:**
     * Anonymous user access is denied.
     * All users must login in with an email address
     * All users have a password that is 8 to 32 characters long and alphanumeric with special characters.
2. ***Display All Rocks Identified***
   * **Detail:** All rocks that have been identified should be visible to all other authenticated users.
   * **Solution:**
     * Once a rock has been successfully identified, it will be displayed in a list displayed in the order of completion date.
     * All identified rocks will be displayed in one page.
3. ***Display All Action History***
   * **Detail:** All actions are tracked and displayed for all authenticated users.
   * **Solution:**
     * The following actions are tracked:
       * Login
       * Logout
       * Rock identified
       * User added
     * All actions will be displayed in one page.
4. ***Identify Rock***
   * **Detail:** An authenticated user can step through the process to identify a rock.
   * **Solution:**
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

### Functional Grouping ###

The high-level functional breakdown of RockId includes: 
 * _User Interface_
   * [Angular](https://angular.io/)
   * [Angular Material Design Components - Web](https://github.com/trimox/angular-mdc-web)
 * _Rock Identification_
   * [Question, Answer, and Result Process](Documents/QARP.md)
 * _Rock Collection Management_
   * [Angular data-table](https://github.com/swimlane/ngx-datatable)
 * _Event Logging_
   * [RabbitMQ](http://www.rabbitmq.com/download.html)
 * _User Security_
   * [IdentityServer4](https://github.com/IdentityServer/IdentityServer4)
 * _Common_

---------------------------------------

## Implementation ##

### Microservice API Projects ###

Each microservice uses its own database on the server.

* [qarp](Source/Api/QARP) - provides the implementation of the [Question, Answser, and Result Process](Documents/QARP.md) microservices.  


### API Application Layers ###

1. Controller
   * This provides the web api controllers that respond to requests for the service.
2. Dto
   * A data transfer object is used when the model object is not sufficient for exposing data outside of the API.
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
* [SQL Server Express 2017](https://www.microsoft.com/en-us/sql-server/sql-server-editions-express)
* [RabbitMQ](http://www.rabbitmq.com/download.html)
* [IdentityServer4](https://github.com/IdentityServer/IdentityServer4)

### Installation Steps ###

* TBD - Once the application is capable of identifying a rock, this needs to be completed.

### Build ###

* TBD - Once the application is capable of identifying a rock, this needs to be completed.

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

0.1.1

### Languages ###

* [TypeScript 2.7](https://www.typescriptlang.org/)
* [C# 7.3](https://docs.microsoft.com/en-us/dotnet/csharp/whats-new/csharp-7-3)

### ChangeLog ###

* 0.1.1
  * Update to release numbering to match the milestone numbering.
* 0.1.0  
  * Milestone 1 is complete
  * Database migrations implemented
  * QARP Web Api implemented for first question and answers
  * UI leverages the QARP Web Api
* 0.0.4
  * Removed Docker container development and switching to Material Design
* 0.0.3
  * Switching to a Docker Container development and deployment approach
* 0.0.2
  * Created features, epics, milestones, and wire frames
* 0.0.1
  * initial creation
