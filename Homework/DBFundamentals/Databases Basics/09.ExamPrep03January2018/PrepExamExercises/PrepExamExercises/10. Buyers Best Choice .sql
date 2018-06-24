SELECT Names, Class
  FROM(
	SELECT CONCAT(c.FirstName, ' ', c.LastName) AS Names,
		   m.Class AS Class,
		   RANK() OVER (PARTITION BY CONCAT(c.FirstName, ' ', c.LastName) ORDER BY COUNT(m.Class) DESC) AS MostFrequentOrdered
	  FROM Orders AS o
	  JOIN Clients AS c ON o.ClientId = c.Id
	  JOIN Vehicles AS v ON v.Id = o.VehicleId
	  JOIN Models AS m ON m.Id = v.ModelId
	GROUP BY CONCAT(c.FirstName, ' ', c.LastName), m.Class
	) AS H
WHERE MostFrequentOrdered = 1
ORDER BY Names, Class
