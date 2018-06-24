CREATE TABLE NotificationEmails( 
	Id INT IDENTITY NOT NULL,
	Recipient INT NOT NULL FOREIGN KEY REFERENCES Accounts(Id),
	[Subject] VARCHAR(50) NOT NULL,
	Body VARCHAR(50) NOT NULL 
)

CREATE TRIGGER TR_NotificationEmailsAfterInsert
            ON Logs AFTER INSERT
AS
BEGIN
	INSERT INTO NotificationEmails(Recipient, [Subject], Body)
	SELECT i.AccountId,
	       CONCAT('Balance change for account: ', i.AccountId),
		   CONCAT('On', GETDATE(), ' your balance was changed from ', i.OldSum,
		   ' to ', i.NewSum)
	  FROM inserted AS i 
END

