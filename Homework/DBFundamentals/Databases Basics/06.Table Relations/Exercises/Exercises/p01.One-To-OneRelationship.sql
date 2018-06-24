CREATE TABLE Passports(
	PassportID INT NOT NULL,
	PassportNumber VARCHAR(50) NOT NULL,

	CONSTRAINT PK_Passports
	PRIMARY KEY (PassportID)
)

CREATE TABLE Persons(
	PersonID INT NOT NULL IDENTITY,
	FirstName VARCHAR(50) NOT NULL,
	Salary MONEY NOT NULL,
	PassportID INT NOT NULL,
	 
	CONSTRAINT PK_Persons
	PRIMARY KEY (PersonID), 

	CONSTRAINT FK_Persons_Passports
	FOREIGN KEY (PassportID)
	REFERENCES Passports(PassportID)
)

INSERT INTO Passports(PassportID, PassportNumber) VALUES
(101, 'N34FG21B'),
(102, 'K65LO4R7'),
(103, 'ZE657QP2')

INSERT INTO Persons VALUES
('Roberto', 43300.00, 102),
('Tom', 56100.00, 103),
('Roberto', 60200.00, 101)

                                            