  SELECT emp.EmployeeID, emp.FirstName,  
         CASE 
          WHEN P.StartDate > '01/01/2005' THEN NULL
          ELSE P.NAME
         END AS ProjectName
    FROM Employees AS emp
    JOIN EmployeesProjects AS ep
      ON emp.EmployeeID = ep.EmployeeID
	 AND emp.EmployeeID = 24
    JOIN Projects AS p
      ON ep.ProjectID = p.ProjectID
	 
	     