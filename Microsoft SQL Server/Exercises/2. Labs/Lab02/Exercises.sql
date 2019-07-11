/* Working with SELECT */


/* 1) Select all columns and rows from the Sales.SalesOrderHeader table */


/* 2) Select specific columns and all rows from the Sales.SalesOrderHeader table */



/* 3) Select specific columns and rows from the Sales.SalesOrderHeader table where SalespersonID is 279 */



/* 4) Select specific columns and rows from the Sales.SalesOrderHeader table where SalespersonID is 279 or 282 */



/* 5) Select specific columns and rows from the Sales.SalesOrderHeader table 
where SalespersonID is 279 and the year of OrderDate = 2014 
The results should be ordered by OrderDate */



/* 6) Select specific columns and rows from the Sales.SalesOrderHeader table 
where SalespersonID is 279 and the year OrderDate = 2014 
The results should be ordered by OrderDate in descending order */



/* 7) Select specific columns and rows from the Sales.SalesOrderHeader table 
where SalespersonID = 279 and the OrderDate year = 2014 
The results should be ordered by OrderDate in descending order and by SalesOrderId in descending order */



/* Working with INSERT */
/***************************************************************
1)Write an INSERT statement to add a record to the Employees table 
with the following values:

•Title: Sales Representative
•Titleofcourtesy: Mr
•FirstName: Laurence
•Lastname: Grider
•Hiredate: 04/04/2016
•Birthdate: 10/25/1975
•Address: 1234 1st Ave. S.E.
•City: Seattle
•Country: USA
•Phone: (206)555-0105
*****************************************************************/

/***************************************************************
2) Write an INSERT statement to add a record to the Employees table 
with the following values:

•Title: Sales Representative
•Titleofcourtesy: Mr
•FirstName: Laurence
•Lastname: Grider
•Hiredate: 04/04/2016
•Birthdate: 10/25/1975
•Address: 1234 1st Ave. S.E.
•City: Seattle
•Country: USA
•Phone: (206)555-0105

AND

•Title: Jon Snow
•Titleofcourtesy: Mr
•FirstName: Laurence
•Lastname: Grider
•Hiredate: 04/04/2016
•Birthdate: 10/25/1975
•Address: 1234 1st Ave. S.E.
•City: Brasov
•Country: Romania
•Phone: (206)555-0105
*****************************************************************/



/* Working with UPDATE */
/* 1) Update the address of Jon Snow to 'Turnului 5' value */

/* 2) Update the lastname of all persons named 'Grider' to 'Grider XYZ' */ 

/* 3) Rollback previous update (Update the lastname of all presons called 'Grider XYZ' to 'Grider' */

/* 4) Update the last name of ONE OF THE persons named 'Grider' to 'Grider XYZ' */


/* Working with DELETE */
/* 1) Delete the employee with lastname 'Snow' */


/* 2) Delete all employees with lastname 'Grider' */


/* 3) Delete employee with id 13 */
