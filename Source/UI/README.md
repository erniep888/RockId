# RockId UI #

## Development - Docker Details ##

Run with Docker Compose
   ```Docker
   docker-compose -f .\docker-compose.dev.yml up
   ```

Force Rebuild and Run with Docker Compose
   ```Docker
   docker-compose -f .\docker-compose.dev.yml up --build   
   ```

Build the Image From Scratch
   ```Docker
   docker pull node:8.11
   docker tag 8198006b2b57 erniep888/angular-cli
   docker run -it -p 4200:4200 -v ${pwd}/rock-id:/app erniep888/angular-cli /bin/bash
   npm i -g @angular/cli
   docker commit  6817f658ab83 erniep888/angular-cli:latest
   ```

Build the Image From Docker Development File
   ```Docker
   docker build -f .\Dev.Dockerfile -t erniep888/angular-cli .
   ```

Interactive Manual Run of the Container
   ```Docker
   docker run -it -p 4200:4200 -v ${pwd}/rock-id:/app erniep888/angular-cli:latest
   ```