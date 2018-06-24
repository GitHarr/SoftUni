SELECT [Name]
  FROM Towns
 WHERE LEN([Name]) = 5 OR LEN([Name]) = 6
--WHERE LEN([Name]) IN (5, 6)
ORDER BY [Name]