DROP DATABASE CommanderDb
GO

DROP USER CommanderApi
GO

CREATE LOGIN CommanderApi WITH PASSWORD='Commander9',
    DEFAULT_DATABASE=CommanderDb, CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO

USE CommanderDb
GO

CREATE USER CommanderApi FOR LOGIN CommanderApi
GO

GRANT ALL ON CommanderDb TO 'CommanderApi'@'localhost'