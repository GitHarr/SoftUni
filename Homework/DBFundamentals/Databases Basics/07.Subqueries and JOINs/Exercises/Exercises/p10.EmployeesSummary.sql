SELECT TOP 50 
  e.EmployeeID, 
  e.FirstName + ' ' + e.LastName AS EmployeeName, 
  m.FirstName + ' ' + m. LastName AS ManagerName,
  d.Name AS DepartmentName
FROM Employees AS e
  LEFT JOIN Employees AS m ON m.EmployeeID = e.ManagerID
  LEFT JOIN Departments AS d ON d.DepartmentID = e.DepartmentID
   ORDER BY e.EmployeeID ASC
