CREATE PROC usp_CalculateFutureValueForAccount 
			(@accountId INT, @interestRate FLOAT) AS
BEGIN
	SELECT a.Id, ah.FirstName, ah.LastName, a.Balance, 
		   dbo.ufn_CalculateFutureValue(Balance, @interestRate, 5) 
		   AS [Balance in 5 years]
	  FROM Accounts AS a
	  JOIN AccountHolders AS ah ON ah.Id = a.AccountHolderId
     WHERE a.Id = @accountId
END