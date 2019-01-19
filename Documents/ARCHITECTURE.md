# :triangular_ruler: RockId Architecture #

## Description ##

This application adheres to a layered architecture intended to abstract dependencies in order to increase modularity and testability. A layer can only call into a layer that sits below it.

## Microservices ##
* [sql-qarp](https://cloud.docker.com/repository/docker/erniep888/sql-qarp) - provides the sql server 2017 database for the QARP microservice.

## Application Layers ##

1. API
    * This represents the API Gateway and all microservices that make up the backend features of the application.  In general, all Web API's are made up of a set of RESTful controllers that return JSON payloads.  Each controller yields to a service class in the Application layer which is where the business logic begins in the microservice backend.
2. Application
      * This represents the services that relate to the application requirements directly.  The API controllers call the services in the Application layer by passing along the parameters from the controller and expecting a DTO from the service in response.  
3. Domain
    * Contains the data model and services that are invariant of use cases.  
4. Infrastructure
    * Contains the ORM, external web services, security API, logging, tracing, IoC containers, email, caching, etc.