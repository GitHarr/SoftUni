SELECT	[Name], Email, Bill, Town
  FROM(	
	SELECT ROW_NUMBER() OVER (PARTITION BY t.[Name] ORDER BY o.Bill DESC) AS OrderByHighestBillDesc,
		   CONCAT(c.FirstName, ' ', c.LastName) AS [Name],
		   c.Id AS ClientId,
		   c.Email, o.Bill, t.[Name] AS Town
	  FROM Orders AS o
	  JOIN Clients AS c ON c.Id = o.ClientId
	  JOIN Towns AS t ON t.Id = o.TownId
	 WHERE o.CollectionDate > c.CardValidity AND o.Bill IS NOT NULL
	 ) AS H
 WHERE OrderByHighestBillDesc IN (1, 2)
ORDER BY Town, Bill, ClientId