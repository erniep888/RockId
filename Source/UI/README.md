# RockId UI#

## Docker Details ##

Build Image
```Docker
docker build -f .\Dev.Dockerfile -t erniep888/angular .
```
_May want to version the image itself._

Run the Container
```Docker
docker run -p 4200:4200 -v ${pwd}/rock-id:/app erniep888/angular:latest
```