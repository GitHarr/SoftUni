CREATE PROC usp_GetEmployeesSalaryAboveNumber(@amount DECIMAL(18, 4))
AS 
	SELECT FirstName, LastName
	  FROM Employees
     WHERE Salary >= @amount

EXEC usp_GetEmployeesSalaryAboveNumber 48100.0