SELECT * INTO EmployeesAverageSalary
  FROM Employees
 WHERE Salary > 30000

 DELETE FROM EmployeesAverageSalary
  WHERE ManagerID = 42

UPDATE EmployeesAverageSalary
   SET Salary += 5000
 WHERE DepartmentID = 1

 SELECT DepartmentID, AVG(Salary) AS AverageSalary
   FROM EmployeesAverageSalary
GROUP BY DepartmentID