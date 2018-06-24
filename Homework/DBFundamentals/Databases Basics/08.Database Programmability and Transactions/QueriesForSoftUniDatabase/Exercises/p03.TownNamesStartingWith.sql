CREATE PROC usp_GetTownsStartingWith(@startString VARCHAR(5))
AS
	SELECT [Name]
	  FROM Towns
	 WHERE [Name] LIKE @startString + '%'

