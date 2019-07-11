USE [TSQL]
GO

SELECT * FROM HR.Employees

INSERT INTO HR.Employees (Title, titleofcourtesy, FirstName, Lastname, hiredate, birthdate, address, city, country, phone)
VALUES ('Sales Representative', 'Mr', 'Laurence', 'Grider', '04/04/2016', '10/25/1975', '1234 1st Ave. S.E.', 'Seattle', 'USA', '(206)555-0105');


INSERT INTO HR.Employees (Title, titleofcourtesy, FirstName, Lastname, hiredate, birthdate, address, city, country, phone)
VALUES ('Sales Representative', 'Mr', 'Laurence', 'Grider', '04/04/2016', '10/25/1975', '1234 1st Ave. S.E.', 'Seattle', 'USA', '(206)555-0105'),
	   ('CEO', 'Mr', 'Jon', 'Snow', '04/04/2016', '10/25/1975', '1234 1st Ave. S.E.', 'Brasov', 'Romania', '(206)555-0105');

DELETE FROM SALES.OrderDetails

-- The OrderDetails will be put back using INSERT .. SELECT
INSERT Sales.OrderDetails (orderid, productid, unitprice, qty, discount)
SELECT * FROM NewOrderDetails


/* UPDATE */ 
SELECT * FROM HR.Employees

UPDATE HR.Employees 
SET address = 'Turnului 5'
WHERE lastname = 'Snow'


UPDATE HR.Employees
SET lastname = 'Grider XYZ'
WHERE lastname = 'Grider'

/* ROLLBACK PREVIOUS UPDATE */
UPDATE HR.Employees
SET lastname = 'Grider'
WHERE lastname = 'Grider XYZ'


UPDATE HR.Employees
SET lastname = 'Grider XYZ'
WHERE empid = 13



/* DELETE */

DELETE FROM HR.Employees
WHERE lastname = 'Snow'
-- WHERE empid = 16

DELETE FROM HR.Employees
WHERE lastname = 'Grider'


DELETE FROM HR.Employees
WHERE empid = 13