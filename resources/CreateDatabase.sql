-- /resources/DbSeed.sql

-- Use this file to create the initial database
-- that is used by the API

-- CAUTION: This file will delete an existing
-- database with the same name if it exists.

USE master;
GO

IF DB_ID (N'explorphotos') IS NOT NULL
DROP DATABASE explorphotos;
GO

CREATE DATABASE explorphotos;
GO

ALTER DATABASE explorphotos SET AUTO_CLOSE OFF 
GO

USE explorphotos;
GO

CREATE TABLE photos 
   (photoID int PRIMARY KEY NOT NULL,  
   lat nvarchar(15) NOT NULL,
   lng nvarchar(15) NOT NULL,
   fileName nvarchar(50) NOT NULL,
   camera nvarchar(15),
   lens nvarchar(15),
   uploaded DATETIME)  
GO  