SELECT CONCAT(m.FirstName, ' ', m.LastName) AS [Mechanic],
       AVG(DATEDIFF(DAY, j.IssueDate, j.FinishDate)) AS [Average Days]
  FROM Mechanics AS m
  JOIN Jobs AS j ON j.MechanicId = m.MechanicId AND j.[Status] = 'Finished'
GROUP BY m.FirstName, m.LastName, M.MechanicId
ORDER BY m.MechanicId