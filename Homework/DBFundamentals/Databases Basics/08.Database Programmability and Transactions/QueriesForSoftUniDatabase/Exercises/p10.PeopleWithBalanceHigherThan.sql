CREATE PROC usp_GetHoldersWithBalanceHigherThan (@inputNumber DECIMAL(15,4)) AS
BEGIN
	WITH CTE_AccountHolderBalance (AccountHolderId, Balance) AS (
		SELECT AccountHolderId, SUM(Balance) AS TotalBalance
		  FROM Accounts
	  GROUP BY AccountHolderId) 

	    SELECT FirstName, LastName
		  FROM AccountHolders AS ah
		  JOIN CTE_AccountHolderBalance AS cab ON cab.AccountHolderId = ah.Id
		 WHERE cab.Balance > @inputNumber
	  ORDER BY ah.LastName, ah.FirstName 	
END