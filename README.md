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
Thus, until the Data access layer is properly implemented, the second request will always return an object with id = 0.


#### After getting it hooked up to a database:
Development should move quickly, expanding the repitore of possible Http Requests it can accept to 6 different requests.
These will faciliate full CRUD operations on our SQL express Database

#### After development and testing on the .net side is finished:
a small Angular front end will be constructed to handle sending of requests.
It will utalize CSS grid, constructing a reactive and responsive layout.
