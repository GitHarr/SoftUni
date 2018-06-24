  SELECT TOP(5) emp.EmployeeID, emp.FirstName,  p.Name
    FROM Employees AS emp
    JOIN EmployeesProjects AS ep
      ON emp.EmployeeID = ep.EmployeeID
    JOIN Projects AS p
      ON ep.ProjectID = P.ProjectID
     AND p.StartDate > '2002/08/13'
     AND p.EndDate IS NULL
ORDER BY EmployeeID