  SELECT emp.EmployeeID, emp.FirstName, emp.LastName, dep.[Name]
		 AS DepartmentName
    FROM Employees AS emp
    JOIN Departments AS dep
      ON dep.DepartmentID = 3 AND emp.DepartmentID = 3
ORDER BY emp.EmployeeID