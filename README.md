### .net repository README.md
### Programmer: Ben P Sehnert
### Date: 11/17/2020
### Purpose: brief implementation of a .net web api

As of now, the api can handle six requests to the following endpoints:

```
GET api/commands                # returns a list of all commands in db
GET api/commands/{command_id}   # returns a specific command (by id)
POST api/commands               # to create a new command
PUT api/commands/{command_id}   # replace a command (by id)
PATCH api/commands/{command_id} # replace a specific attribute in command
DELETE api/commands/{command_id}# deletes a specific command 
```
We intend to revist this project soon to facilitate a UI for the api with swagger UI, or angular if we have the time to, prior to deployment.
