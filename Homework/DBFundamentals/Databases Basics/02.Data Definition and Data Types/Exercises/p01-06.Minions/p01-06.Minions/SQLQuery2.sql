CREATE DATABASE Minions

CREATE TABLE Minions
(
Id INT NOT NULL,
Name VARCHAR(50) NOT NULL,
Age INT,
PRIMARY KEY (Id)
)

CREATE TABLE Towns
(
Id INT NOT NULL,
Name VARCHAR(50) NOT NULL
PRIMARY KEY (Id)
)


ALTER TABLE Minions
ADD TownId INT

ALTER TABLE Minions     
ADD CONSTRAINT FK_Towns_Minions FOREIGN KEY (TownId) 
REFERENCES Towns (Id)


INSERT Towns
(Id, Name)
VALUES
(1, 'Sofia'),
(2, 'Plovdiv'),
(3, 'Varna')

INSERT Minions
(Id, Name, Age, TownId) 
VALUES
(1, 'Kevin', 22, 1),
(2, 'Bob', 15, 3),
(3, 'Steward', NULL, 2)


TRUNCATE TABLE Minions


DROP TABLE Minions
DROP TABLE Towns

CREATE TABLE People
(
Id INT NOT NULL IDENTITY PRIMARY KEY,
Name NVARCHAR(200) NOT NULL,
Picture VARBINARY(MAX),
Height FLOAT,
Weight FLOAT,
Gender CHAR(1) NOT NULL CHECK(gender in('f','m')),
Birthday DATE NOT NULL,
Biography NVARCHAR(MAX)
)

INSERT People
(Name, Picture, Height, Weight, Gender, Birthday, Biography)
VALUES
('Gosho', NULL, 1.71, 72.5, 'm', '1989-11-24', 'Some blablasdd'),
('Pesho', NULL, 1.72, 73.5, 'm', '1989-11-24', 'Some blabladdas'),
('Gesho', NULL, 1.73, 74.5, 'm', '1989-11-24', 'Some blabladas'),
('Penka', NULL, 1.60, 50, 'f', '1989-11-24', 'Some blabladasaaa'),
('Stoyan', NULL, 1.75, 76.5, 'm', '1989-11-24', 'Some blablayerter')

