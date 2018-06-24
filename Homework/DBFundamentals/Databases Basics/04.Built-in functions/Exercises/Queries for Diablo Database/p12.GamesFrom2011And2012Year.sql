SELECT TOP(50) [Name], FORMAT(Start, 'yyyy-MM-dd') AS StartDate
  FROM Games
 WHERE Start >= '2011-01-01' AND Start <= '2012-12-31'
 ORDER BY StartDate, [Name]