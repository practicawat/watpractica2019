USE [TSQL]
GO

/* Working with SELECT */

/* Select all columns and rows from the Sales.SalesOrderHeader table */
SELECT * FROM Sales.SalesOrderHeader;
GO

/* Select specific columns and all rows from the Sales.SalesOrderHeader table */
SELECT SalesOrderID, OrderDate, SalesPersonID
FROM Sales.SalesOrderHeader;
GO

/* Select specific columns and rows from the Sales.SalesOrderHeader table 
where SalespersonID = 279 */
SELECT SalesOrderID, OrderDate, SalesPersonID
FROM Sales.SalesOrderHeader
WHERE SalesPersonID = 279;
GO

/* Select specific columns and rows from the Sales.SalesOrderHeader table 
where SalespersonID = 279 or SalespersonID = 282 */
SELECT SalesOrderID, OrderDate, SalesPersonID
FROM Sales.SalesOrderHeader
WHERE SalesPersonID = 279 OR SalesPersonID = 282;
GO


/* Select specific columns and rows from the Sales.SalesOrderHeader table 
where SalespersonID = 279 and the OrderDate year = 2014 
ordered by OrderDate */
SELECT SalesOrderID, OrderDate
FROM Sales.SalesOrderHeader
WHERE SalesPersonID = 279 AND Year(OrderDate) = 2014
ORDER BY OrderDate
GO


/* Select specific columns and rows from the Sales.SalesOrderHeader table 
where SalespersonID = 279 and the OrderDate year = 2014 
ordered by OrderDate descending*/
SELECT SalesOrderID, OrderDate
FROM Sales.SalesOrderHeader
WHERE SalesPersonID = 279 AND Year(OrderDate) = 2014
ORDER BY OrderDate DESC
GO

/* Select specific columns and rows from the Sales.SalesOrderHeader table 
where SalespersonID = 279 and the OrderDate year = 2014 
ordered by OrderDate and by SalesOrderId descending */
SELECT SalesOrderID, OrderDate
FROM Sales.SalesOrderHeader
WHERE SalesPersonID = 279 AND Year(OrderDate) = 2014
ORDER BY OrderDate DESC, SalesOrderID DESC
GO



/* Working with INSERT */

-- 1)
INSERT INTO HR.Employees (Title, titleofcourtesy, FirstName, Lastname, hiredate, birthdate, address, city, country, phone)
VALUES ('Sales Representative', 'Mr', 'Laurence', 'Grider', '04/04/2016', '10/25/1975', '1234 1st Ave. S.E.', 'Seattle', 'USA', '(206)555-0105');

-- 2) 
INSERT INTO HR.Employees (Title, titleofcourtesy, FirstName, Lastname, hiredate, birthdate, address, city, country, phone)
VALUES ('Sales Representative', 'Mr', 'Laurence', 'Grider', '04/04/2016', '10/25/1975', '1234 1st Ave. S.E.', 'Seattle', 'USA', '(206)555-0105'),
	   ('CEO', 'Mr', 'Jon', 'Snow', '04/04/2016', '10/25/1975', '1234 1st Ave. S.E.', 'Brasov', 'Romania', '(206)555-0105');
	   

/* WORKING WITH UPDATE */
SELECT * FROM HR.Employees

/* 1) Update the address of Jon Snow to 'Turnului 5' value */
UPDATE HR.Employees 
SET address = 'Turnului 5'
WHERE lastname = 'Snow'

/* 2) Update the lastname of all persons named 'Grider' to 'Grider XYZ' */ 
UPDATE HR.Employees
SET lastname = 'Grider XYZ'
WHERE lastname = 'Grider'

/* 3) Rollback previous update (Update the lastname of all presons called 'Grider XYZ' to 'Grider' */
UPDATE HR.Employees
SET lastname = 'Grider'
WHERE lastname = 'Grider XYZ'

/* 4) Update the last name of ONE OF THE persons named 'Grider' to 'Grider XYZ' */
UPDATE HR.Employees
SET lastname = 'Grider XYZ'
WHERE empid = 13
	   
	   
/* Working with DELETE */
/* 1) Delete the employee with lastname 'Snow' */
DELETE FROM HR.Employees
WHERE lastname = 'Snow'
-- WHERE empid = 16

/* 2) Delete all employees with lastname 'Grider' */
DELETE FROM HR.Employees
WHERE lastname = 'Grider'

/* 3) Delete employee with id 13 */
DELETE FROM HR.Employees
WHERE empid = 13