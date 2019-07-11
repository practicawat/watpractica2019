--Create a database and change database context
USE [master];
GO

/* 1) Create "DEMO" database */


USE Demo;
GO


/* 2) Create Customer table having the following columns: 
CustomerID surrogate PK
Name does not allow nulls
DateOfBirth allows nuls
Address does not allow nulls 	*/







/* 3) Create Order table having the following columns:
OrderID surrogate PK
CustomerID does NOT accept nulls, FK to customer table, CustomerID column
OrderDate does NOT accept nulls 	*/





/* 4) Create CustomerDemographics table having the following columns:
CustomerID surrogate PK
Age does NOT accept nulls 	
NumberOfChildren	does not accept nulls	*/




/* 5) Create Employee table having the following columns:
EmployeeID surrogate PK
CNP does NOT accept nulls and should be exactly 13 characters 	
LastName does not accept nulls
Firstname does not accept nulls	*/



/* 6) Add CHECK constraint to dbo.Order to ensure the OrderDate is always the current date  */


--Test CHECK constraint




/* 7) Add DEFAULT constraint to dbo.CustomerDemographics to ensure the number of children 
is set to -1 if the value is not present in the insert command */



--Test DEFAULT constraint


/* 8) Add UNIQUE constraint to dbo.Employee to ensure the CNP is always unique	*/


--Test UNIQUE constraint. 


