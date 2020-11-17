### .net repository README.md
### Programmer: Ben P Sehnert
### Date: 11/17/2020
### Purpose: brief implementation of a .net web api

As of now, the api can handle two GET requests to the following endpoints:

```
/api/commands
/api/commands/{command_id}
```

Note that the second request is a hard coded, static result.
It simply serves as a prototype of how the controller and repository communicate using Dependency Injection.
Meaning that until the Data access layer is properly implemented,
the second request will always return the same command object.

#### After getting it hooked up to a database:
Development should move quickly, expanding the repitore of possible
HTTP requests the api can accept to 6 different requests.
These will faciliate full CRUD operations on our SQL Express Database

#### After development and testing on the .net side is finished:
A small Angular front end will be built to handle sending of requests from the client side.
It will utalize CSS grid to construct a reactive, responsive and mobile friendly layout.
