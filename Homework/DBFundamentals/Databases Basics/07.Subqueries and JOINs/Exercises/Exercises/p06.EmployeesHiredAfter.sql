    SELECT e.FirstName, e.LastName, e.HireDate,  d.Name as DeptName
      FROM Employees e
INNER JOIN Departments d
        ON (e.DepartmentId = d.DepartmentId 
       AND e.HireDate > '1/1/1999'		  
       AND d.Name IN ('Sales', 'Finance')) --> Complex Join Condition
  ORDER BY e.HireDate ASC

--  SELECT emp.FirstName, emp.LastName, emp.HireDate, dep.Name AS DeptName
--    FROM Employees AS emp
--    JOIN Departments AS dep
--      ON emp.DepartmentID = dep.DepartmentID
--   WHERE HireDate > '1999/01/01'
--     AND dep.Name = 'Sales' OR dep.Name = 'Finance' 
--ORDER BY emp.HireDate
