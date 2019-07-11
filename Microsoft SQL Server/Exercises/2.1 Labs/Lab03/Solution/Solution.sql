--Create a database and change database context
USE [master];
GO


CREATE DATABASE Demo;
GO

USE Demo;
GO


--Create tables
CREATE TABLE dbo.Customer
(CustomerID INT IDENTITY (1,1) NOT NULL
,Name VARCHAR (50) NOT NULL
,DateOfBirth DATETIME NULL
,Address VARCHAR (50) NOT NULL CONSTRAINT PK_Customer PRIMARY KEY (CustomerID));
GO

CREATE TABLE dbo.[Order]
(OrderID INT IDENTITY (1,1) NOT NULL
,CustomerID INT NOT NULL
,OrderDate DATETIME NOT NULL 
CONSTRAINT PK_OrderID PRIMARY KEY (OrderID)
CONSTRAINT FK_Order_Customer FOREIGN KEY (CustomerID) REFERENCES dbo.Customer (CustomerID));
GO

CREATE TABLE dbo.CustomerDemographics
(CustomerID int NOT NULL PRIMARY KEY
,Age tinyint NOT NULL 
,NumberOfChildren smallint NOT NULL 
CONSTRAINT FK_CustomerDemographics_Customer FOREIGN KEY (CustomerID) REFERENCES dbo.Customer (CustomerID));
GO

CREATE TABLE dbo.Employee
(EmployeeID int IDENTITY NOT NULL PRIMARY KEY
,CNP char (12) NOT NULL
,LastName varchar (50) NOT NULL
,Firstname varchar (50) NOT NULL);
GO


INSERT INTO dbo.[Order]
VALUES(4,GETDATE()-1);
GO


--Add CHECK constraint to dbo.Order
ALTER TABLE dbo.[Order] ADD CONSTRAINT DF_OrderDate
    CHECK (OrderDate = GETDATE());
GO

--Test CHECK constraint
INSERT INTO dbo.[Order]
VALUES(4,GETDATE()-1);
GO



--Test DEFAULT constraint
INSERT INTO dbo.Customer
VALUES ('Customer 1', '1 June 1987', '1 High Street');
GO

INSERT INTO dbo.CustomerDemographics (CustomerID, Age)
VALUES (1,23)

--Add DEFAULT constraint to dbo.CustomerDemographics
ALTER TABLE dbo.CustomerDemographics
ADD CONSTRAINT DF_NumberChildren DEFAULT -1 FOR NumberOfChildren;
GO

INSERT INTO dbo.CustomerDemographics (CustomerID, Age)
VALUES (1,23)

SELECT * FROM dbo.CustomerDemographics;
GO

--Add UNIQUE constraint to dbo.Employee
ALTER TABLE dbo.Employee
ADD CONSTRAINT AK_CNP UNIQUE (CNP);
GO

--Test UNIQUE constraint. 

SELECT * FROM dbo.Employee

INSERT INTO dbo.Employee
VALUES (123,'Lastname', 'Firstname');
GO

INSERT INTO dbo.Employee
VALUES (123,'Lastname', 'Firstname');
GO


