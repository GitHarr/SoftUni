SELECT TOP(3) CONCAT(m.FirstName, ' ', m.LastName) AS Mechanic,
	   COUNT(m.MechanicId) AS [Jobs]
  FROM Mechanics AS m
  JOIN Jobs AS j ON j.MechanicId = m.MechanicId AND j.FinishDate IS NULL
GROUP BY m.FirstName, m.LastName, j.MechanicId
HAVING COUNT(m.MechanicId) > 1
ORDER BY Jobs DESC, j.MechanicId
