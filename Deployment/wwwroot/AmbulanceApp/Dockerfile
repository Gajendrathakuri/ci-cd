FROM node:22-alpine As build
WORKDIR /app
COPY package*.json ./
RUN npm ci
COPY . . 
RUN  npm run build

#server angular
FROM nginx:alpine As serve
COPY --from=build /app/dist/AmbulanceApp/browser /usr/share/nginx/html
EXPOSE 80

