# Data Sync Project

This project was made with the aim of demonstrating the user's technical capacity!

## Getting Started

The following prerequisites are required to build and run the solution (IF YOU WILL RUN LOCALLY):

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) (latest version)
- [Node.js](https://nodejs.org/) (latest LTS)

You will need to enter in ./Application1 and run 
```bash
dotnet run
```

And enter in ./SignalRServer and run 
```bash
dotnet run
```

and to run the frontend just enter in ./application2
```bash
npm install
npm start
```

The following prerequisites are required to build and run the solution (if you will with Docker):
- [Docker](https://www.docker.com/) (latest LTS / if you needed)

After that the easiest way to get started is run (in root path, where docker-compose is located):
```
docker-compose up
```

## Technologies

* [Docker](https://www.docker.com/)
* [ASP.NET Core 8](https://docs.microsoft.com/en-us/aspnet/core/introduction-to-aspnet-core)
* [React 18](https://react.dev/)
* [Bootstrap](https://react-bootstrap.netlify.app/)


## Critique

In this project it was something that I saw a great possibility of scalability, because of this a lot of things can be improved in it so that when it reaches high usage the system does not become overloaded and remains stable.

### Structure

Both the front and back are made with the best possible structure for the moment, however I see that for the backend it is necessary to add new divisions for the project to have the identity of a complete clean architecture. For the front I see the division into more components for better reuse.

### Design System

As the idea is something scalable for the front, a good idea is to create an entire design system of its own with original and unique palettes to leave the system with a Posterr look and also for any extension to follow the same basis. One idea would be to implement StoryBook completely and effectively.

### UX & UI 

Improve the user interface and user experience to get a better usability and accessibility, create responsive design for mobile and another screen sizes

