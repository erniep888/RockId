# RockId #

## Definition ##

The application is called RockId.  It allows a person to identify a rock based on responses to a series of questions and answers.  Each identified rock is placed in a rock collection where more information can be associated with the rock.  All significant events can be viewed by all users and all identified rocks can be viewed by all users.

RockId provides a consistent problem domain for research in implementation strategies and technologies relating to web and mobile development.  This allows my team to brainstorm and share design ideas, project management approaches, and more before committing to new endeavors where the business domain is not well known.  Anyone that reads this should feel free to clone, change, and contribute ideas for new approaches or technological solutions.

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

  - [UI](Source/UI/spa-ng) - Contains the user interface implemented in Angular 7
  - [Api Gateway](Source/Gateway/BackendForFrontend_Spa) - Contains the [Ocelot](http://threemammals.com/ocelot) API Gateway that enables a single entry point for all api calls to the backend among other [benefits](https://microservices.io/patterns/apigateway.html).
  - [Api - QARP](Source/Api/RockId.Qarp) - Contains the microservice api that implements a [Question, Answser, and Result Process](Documents/QARP.md) to identify rocks.
  - Api - Identified Rock - _Incomplete_ Contains the microservice api that allows identified rocks to be searched, edited, and removed.
  - Api - Event Logger - _Incomplete_ Contains the microservice api that allows all other services to log specific events and actions.
  - Api - Identity - _Incomplete_ This microservice is an identity provider implemented with IdentityServer 4.
  - Common - EventBus - _Incomplete_ Contains an event bus that leverages RabbitMQ in order to allow services to communicate in a loosely coupled manner.  
  - [Common - Models](Source/Common/RockId.Common) - Provides model implementations that are shared among the Api projects. 

---------------------------------------
## Project Process ##

1. Intake the business requirements.
2. Refine and create a title for each requirement.
3. Create features based on requirements.
4. Create epics and stories within GitHub whose parent is one of features.
5. Create milestones that identify stories to be implemented as part of the milestone.
6. Plan the milestones as not to violate implementation dependencies and in consideration of team and customer schedules.
7. Implement (includes iterative technical design, development, unit testing, QA deployment, QA testing, and Production deployment)
8. Track and share the progress as percentage complete of a given feature.

## Project Status ##

|  User Security |     Rocks     |  User Events |  Dashboard   |  Identify Rock |
| -------------- | ------------- | ------------ | ------------ | -------------- |
|       0%       |       0%      |      0%      |      0%      |       40%      |
|  :red_circle:  | :red_circle:  | :red_circle: | :red_circle: | :white_circle: |
  
## Business Requirements ##

1. All users must be able to login. _title :_ ***User Security***
2. All identified rocks must be searchable by all users. _title :_ ***Rocks***
3. Significant user actions must be tracked and searchable by all users. _title :_ ***User Events***
      * Rock identified
      * User added
      * User logged in
4. The initial screen for the user should be a dashboard. _title :_ ***Dashboard***
      * My Rock Identification Count
      * Total Rock Identification Count
5. All users should be able to identify a rock using the [QARP](Documents/QARP.md) process. _title :_ ***Identify Rock***

---------------------------------------

## Features Based On Requirements ##

1. ***User Security***
   * **Detail:** All users must be known to the system.
   * **Solution:**
     * Anonymous user access is denied.
     * All users must login in with an email address
     * All users have a password that is 8 to 32 characters long and alphanumeric with special characters.
2. ***Rocks***
   * **Detail:** All rocks that have been identified should be visible to all other authenticated users.
   * **Solution:**
     * Once a rock has been successfully identified, it will be displayed in a list displayed in the order of completion date.
     * All identified rocks will be displayed in one page.
3. ***User Events***
   * **Detail:** All actions are tracked and displayed for all authenticated users.
   * **Solution:**
     * The following actions are tracked:
       * Login
       * Logout
       * Rock identified
       * User added
     * All actions will be displayed in one page.
4. ***Dashboard***
   * **Detail:** Two widgets are displayed on the dashboard for all authenticated users.
   * **Solution:**
     * The following widgets are displayed:
       * My Rock Identification Count
       * Total Rock Identification Count
5. ***Identify Rock***
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

---------------------------------------

## Implementation Notes ##

The high-level functional breakdown of RockId includes: 
 * _General_
   * [Angular](https://angular.io/)
   * [Angular Material Design Components - Web](https://github.com/trimox/angular-mdc-web) 
   * [ASP.NET Core 2.2 Web API](https://docs.microsoft.com/en-us/aspnet/core/web-api/?view=aspnetcore-2.2)
   * [Visual Studio 2017](https://visualstudio.microsoft.com/vs/)
   * [SQL Server Express 2017](https://www.microsoft.com/en-us/sql-server/sql-server-editions-express)
 * _User Security_
   * [IdentityServer4](https://github.com/IdentityServer/IdentityServer4)
 * _Rocks_
   * [Angular data-table](https://github.com/swimlane/ngx-datatable)
 * _User Events_
   * [RabbitMQ](http://www.rabbitmq.com/download.html) 
* _Rock Identification_
   * [Question, Answer, and Result Process](Documents/QARP.md)

---------------------------------------

### Concepts ###

* [QARP](Documents/QARP.md) - QARP stands for the **Q**uestion, **A**nswer, and **R**esult **P**rocess that is used to identify a rock specimen. 

---------------------------------------

## Development ##

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
