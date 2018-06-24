CREATE TABLE Clients(
Id INT PRIMARY KEY IDENTITY,
FirstName NVARCHAR(30) NOT NULL,
LastName NVARCHAR(30) NOT NULL,
Gender CHAR(1) CHECK(Gender IN ('M', 'F')),
BirthDate DATETIME,
CreditCard NVARCHAR(30) NOT NULL,
CardValidity DATETIME,
Email NVARCHAR(50) NOT NULL
)

CREATE TABLE Towns(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(50) NOT NULL
)

CREATE TABLE Offices(
Id INT PRIMARY KEY IDENTITY,
[Name] NVARCHAR(40),
ParkingPlaces INT,
TownId INT NOT NULL FOREIGN KEY(TownId) REFERENCES Towns(Id)
)

CREATE TABLE Models(
Id INT PRIMARY KEY IDENTITY,
Manufacturer NVARCHAR(50) NOT NULL,
Model NVARCHAR(50) NOT NULL,
ProductionYear DATETIME,
Seats INT,
Class NVARCHAR(10),
Consumption DECIMAL(14, 2)
)

CREATE TABLE Vehicles( 
Id INT PRIMARY KEY IDENTITY,
ModelId INT NOT NULL FOREIGN KEY(ModelId) REFERENCES Models(Id),
OfficeId INT NOT NULL FOREIGN KEY(OfficeId) REFERENCES Offices(Id),
Mileage INT
)

CREATE TABLE Orders(
Id INT PRIMARY KEY IDENTITY,
ClientId INT NOT NULL FOREIGN KEY REFERENCES Clients(Id),
TownId INT NOT NULL FOREIGN KEY REFERENCES Towns(Id),
VehicleId INT NOT NULL FOREIGN KEY REFERENCES Vehicles(Id),
CollectionDate DATETIME NOT NULL,
CollectionOfficeId INT NOT NULL FOREIGN KEY REFERENCES Offices(Id),
ReturnDate DATETIME,
ReturnOfficeId INT FOREIGN KEY REFERENCES Offices(Id),
Bill DECIMAL(14, 2),
TotalMileage INT
)