# What is RockId? #

## Purpose ##

RockId is a web-based application intended to provide a realistic example business problem to solve using a variety of technology stacks.  The intent is to identify an application design and implementation approach that works best for a given team.  Having a consistent business problem to solve provides a more objective system for evaluating different design strategies and architectures.

My team uses this application to brainstorm and share ideas before committing to them for large applications that actually have significant personal or monetary value.  Anyone that reads this should be free to clone, change, and contribute ideas for new approaches and/or technological solutions.

## Description ##

RockId is used to identity a rock as belonging to one of the three possible rock types: igneous, sedimentary, or metamorphic.

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
6. Search all identified rocks using complex criteria:
      * Show me all rocks that were green and could scratch glass.
      * Show me all igneous rocks and display counts for scratch glass and has visible crystals.

## Feature Driven Development ##

1. Create a Feature List
2. Create a Milestone Plan
3. Use the Milestone Plan to begin designing and implementing in iterations

## Technologies ##

[Angular 6, .NET Core Web API, SQL Server, Elastic Search](TECHNOLOGIES.md)

## Architectural Layers ##

* User Interface
* API
     * Controllers
* Business
     * Data Transfer Objects (Dtos)
     * Mappers
     * Logic
* Domain
     * Contexts
     * Filters
     * Models
     * ModelBuilders
* Database

## Deployment Structure ##

* Reverse Proxy on Port 6000 ( [IIS configure](https://blogs.msdn.microsoft.com/friis/2016/08/25/setup-iis-with-url-rewrite-as-a-reverse-proxy-for-real-world-apps/) )
     * Angular UI on Port 5900 ( IIS )
     * Web API on Port 5800 ( IIS )
           * SQL Server 2017
           * Elastic Search

## IdentityServer4 ##

This server enables a centralized login logic for web, mobile, native, and services.  It also supports access control across API's.  IdentityServer has a number of jobs and features - including ([ref](http://docs.identityserver.io/en/release/intro/terminology.html)):

* protect your resources
* authenticate users using a local account store or via an external identity provider
* provide session management and single sign-on
* manage and authenticate clients
* issue identity and access tokens to clients
* validate tokens

[Creation Process](IDENTITYSERVERCREATION.md)

## User Interface ##

Mock-Up

![Capture.PNG](https://bitbucket.org/repo/kM9doxe/images/3953175467-Capture.PNG)