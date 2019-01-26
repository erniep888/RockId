# RockId UI #

## Development - Docker Details ##

Build the Image
   ```Docker
   docker build -f .\Dev.Dockerfile -t erniep888/rock-id-ui .
   ```
   _May want to version the image itself._

Run the Container
   ```Docker
   docker run -p 4200:4200 -v ${pwd}/rock-id:/app erniep888/rock-id-ui:latest
   ```