FROM node:8.11

LABEL AUTHOR="epaschall@gmail.com"

ENV NODE_ENV=development
ENV PORT=4200

EXPOSE $PORT

WORKDIR /app

RUN npm install -g @angular/cli@6.2.9