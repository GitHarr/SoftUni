  SELECT DISTINCT t.[Name] AS TownName,
           COUNT(*) AS OfficesNumber
    FROM Towns AS t
    JOIN Offices AS o ON o.TownId = t.Id
GROUP BY t.[Name], o.TownId
ORDER BY OfficesNumber DESC, TownName
