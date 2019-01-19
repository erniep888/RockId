# :triangular_ruler: RockId Architecture #

## Description ##

This application adheres to a layered architecture intended to abstract dependencies in order to increase modularity and testability. A layer can only call into a layer that sits below it.

## Microservice Images ##
* [sql-qarp](https://cloud.docker.com/repository/docker/erniep888/sql-qarp) - provides the development sql server 2017 database server for the QARP microservices.  Each microservice uses its own database on the server.

## Functional Grouping ##

The primary functions of RockId are 

## Service Application Layers ##

1. Controller
    * This provides the web api controllers that respond to requests for the service.
2. Dto
      * Provides the data transfer objects that are used when the model object is not sufficient.  
3. Domain
    * Contains the data model and services that are invariant of use cases.  
4. Infrastructure
    * Contains the ORM, external web services, security API, logging, tracing, IoC containers, email, caching, etc.