<<<<<<< HEAD
=======
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
>>>>>>> c0347c340ba27046dffe024f317492b3bbcaea6d

NOTE: After an extended period of no use, (or other unknown circumstances) the docker container image is 
erased or forgotten. Thus rendering the API non functional (cannot use ```dotnet run```)

to fix, follow these steps:

```
\\spin up the container
docker compose up -d


\\ if you are using script to init your db, you need to copy it to the container image filesystem.
docker cp commander_db.sql sql-server-db:/

\\log in to the bash terminal
docker exec -it "bash"

\\access the Tsql shell
$ cd opt\mssql-tools\bin
$ .\sqlcmd -S localhost -U SA -super_DUPER_password

\\create the database, then run the script commander_db.sql, or carry out the sql commands outlined within.

\\ Summary: in order for the app to work, database container must be running, the Commander database must exist, and the CommanderApi user and login must exist, with the permissions set so that this login can create,edit,read and delete from that database.  
```

NOTE/TODO: noticed a problem when using this API with postman- the 'id' property which serves as the UID and url postfix for http GET a database entry
doesnt reset the index when you delete or edit entries. Meaning if we POST 3 commands and then delete the third, the next entry will be 4. Not sure
how to go about fixing this but i will research it in due time.