  SELECT TOP(50) emp.FirstName, emp.LastName, t.[Name], addr.AddressText
    FROM Employees AS emp
    JOIN Addresses AS addr
      ON emp.AddressID = addr.AddressID
    JOIN Towns AS t
      ON t.TownID = addr.TownID
ORDER BY emp.FirstName, emp.LastName