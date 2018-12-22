FROM node:latest

COPY ./entrypoint.sh /
RUN sed -i 's/\r//' /entrypoint.sh
RUN chmod +x /entrypoint.sh

WORKDIR /app

CMD /entrypoint.sh
