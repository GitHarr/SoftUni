SELECT FirstName, LastName
  FROM Employees
 WHERE JobTitle NOT LIKE '%engineer%'
-- WHERE CHARINDEX('engineer', JobTitle) = 0