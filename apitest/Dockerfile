FROM node:latest 
ENV NODE_PATH /usr/local/lib/node_modules/
COPY . /app
WORKDIR /app
RUN npm install 
RUN npm install jasmine-node -g
ENTRYPOINT ["jasmine-node", "spec/", "--config", "baseUrl"]
CMD ["http://localhost"]