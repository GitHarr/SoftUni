  SELECT TOP(5) emp.EmployeeID, emp.FirstName, emp.Salary, dep.[Name]
		 AS DepartmentName
    FROM Employees AS emp
    JOIN Departments AS dep
      ON dep.DepartmentID = emp.DepartmentID
   WHERE EMP.Salary > 15000
ORDER BY emp.DepartmentID