# LionWoodBlog
This is a Blog (SPA) site with Angular and ASP.NET Core 5.

## Technologies

* ASP.NET Core 5
* [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
* AutoMapper
* [Angular 11](https://angular.io/)
* MediatR
* CQRS Pattern

## Getting Started
1. Install the latest [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
2. Install the latest [Node.js LTS](https://nodejs.org/en/)
3. Navigate to `client` and run `npm install`
4. Navigate to `client` and run `npm start` to launch the front end (Angular)
5. Navigate to `API` and run `dotnet restore`
6. Change the SQLServer database connection string in `API/appsettings.json`
7. Navigate to `API` and run `dotnet watch run` to launch the back end (ASP.NET Core Web API)
