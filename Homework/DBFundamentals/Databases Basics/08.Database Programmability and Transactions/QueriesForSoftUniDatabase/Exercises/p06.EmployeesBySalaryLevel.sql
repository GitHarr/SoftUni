CREATE PROC usp_EmployeesBySalaryLevel(@salaryLevel CHAR(7))
AS
BEGIN
	SELECT FirstName, LastName
	  FROM Employees
	 WHERE dbo.ufn_GetSalaryLevel(Salary) = @salaryLevel
END

EXEC usp_EmployeesBySalaryLevel 'High'