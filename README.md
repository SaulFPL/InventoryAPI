# Inventory API
Aplicacion de evaluacion

Tablas generadas:

CREATE TABLE Users
(
   UserId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
   UserNames VARCHAR(50),
   UserLastName VARCHAR(50),
   DateOfBirth DATETIME,
   UserPhone BIGINT,
   UserStatus BIT
);

CREATE TABLE Products
(
   ProductId INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
   ProductCode VARCHAR(50),
   ProductName VARCHAR(50),
   ProductPrice NUMERIC(6,2),
   CreateDate DATETIME,
   ProductStatus BIT,
   ProductType VARCHAR(50)
);
