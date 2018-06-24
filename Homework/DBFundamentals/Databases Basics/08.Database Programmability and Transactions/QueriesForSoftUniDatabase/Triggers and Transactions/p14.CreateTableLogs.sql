CREATE TABLE Logs( 
	LogId INT IDENTITY NOT NULL,
	AccountId INT NOT NULL FOREIGN KEY (AccountId) REFERENCES Accounts(Id),
	OldSum DECIMAL(15, 4) NOT NULL,
	NewSum DECIMAL(15, 4) NOT NULL
)

CREATE TRIGGER tr_AccountsUpdate ON Accounts AFTER UPDATE
AS
BEGIN
	INSERT INTO Logs(AccountID,OldSum,NewSum)
	SELECT i.Id, d.Balance, i.Balance 
	FROM inserted AS i
	INNER JOIN deleted AS d
	ON i.Id = d.Id
END
	