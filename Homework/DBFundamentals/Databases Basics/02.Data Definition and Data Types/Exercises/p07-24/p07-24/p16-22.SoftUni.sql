CREATE DATABASE SoftUni

CREATE TABLE Towns
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(20) NOT NULL
)

CREATE TABLE Addresses
(
	Id INT PRIMARY KEY IDENTITY,
	AddressText NVARCHAR(30) NOT NULL,
	TownId INT CONSTRAINT FK_Address_Town FOREIGN KEY REFERENCES Towns(Id) NOT NULL
)

CREATE TABLE Departments
(
	Id INT PRIMARY KEY IDENTITY,
	[Name] NVARCHAR(20) NOT NULL
)

CREATE TABLE Employees
(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(30) NOT NULL,
	MiddleName NVARCHAR(30) NOT NULL,
	LastName NVARCHAR(30) NOT NULL,
	JobTitle NVARCHAR(30) NOT NULL,
	DepartmentId INT CONSTRAINT FK_Employees_Departments FOREIGN KEY 
	REFERENCES Departments(Id) NOT NULL,
	HireDate DATE NOT NULL,
	Salary DECIMAL(15, 2) NOT NULL,
	AddressId INT CONSTRAINT FK_Employees_Addresses FOREIGN KEY 
	REFERENCES Addresses(Id) NOT NULL
)

INSERT INTO Towns ([Name]) VALUES
('Sofia'),
('Plovdiv'),
('Varna'),
('Burgas')

INSERT INTO Departments ([Name]) VALUES
('Engineering'),
('Sales'),
('Marketing'),
('Software Development'),
('Quality Assurance')

ALTER TABLE Employees
ALTER COLUMN AddressId INT

INSERT INTO Employees(FirstName, MiddleName, LastName, JobTitle, DepartmentId, 
HireDate, Salary) VALUES
('Ivan', 'Ivanov', 'Ivanov', '.NET Developer', 4,
CONVERT(DATETIME, '01/02/2013', 103), 3500),
('Peter', 'Petrov', 'Petrov', 'Senior Engineer', 1, 
CONVERT(DATETIME, '02/03/2004', 103), 4000),
('Maria', 'Petrova', 'Ivanova', 'Intern', 5, 
CONVERT(DATETIME, '28/08/2016', 103), 525.25),
('Georgi', 'Terziev', 'Ivanov', 'CEO', 2, 
CONVERT(DATETIME, '09/12/2007', 103), 3000.00),
('Peter', 'Pan', 'Pan', 'Intern', 3, 
CONVERT(DATETIME, '28/08/2016', 103), 599.88)

SELECT Name FROM Towns
ORDER BY [Name]

SELECT Name FROM Departments
ORDER BY [Name]

SELECT FirstName, LastName, JobTitle, Salary FROM Employees
ORDER BY Salary DESC

UPDATE Employees
SET Salary *= 1.1

SELECT Salary FROM Employees

