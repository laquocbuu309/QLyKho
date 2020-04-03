CREATE DATABASE QuanLyKho
GO

USE QuanLyKho
GO

CREATE TABLE Unit
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	DisplayName NVARCHAR(max)
)
GO

CREATE TABLE Customer
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	DisplayName NVARCHAR(max),
	Address NVARCHAR(max),
	Phone NVARCHAR(20),
	Email NVARCHAR(200),
	MoreInfo NVARCHAR(max),
	ContractDate DATETIME
)
GO

CREATE TABLE Suplier
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	DisplayName NVARCHAR(max),
	Address NVARCHAR(max),
	Phone NVARCHAR(20),
	Email NVARCHAR(200),
	MoreInfo NVARCHAR(max),
	ContractDate DATETIME
)
GO

CREATE TABLE Object
(
	Id NVARCHAR(128) PRIMARY KEY,
	DisplayName NVARCHAR(max),
	IdUnit INT NOT NULL,
	IdSuplier INT NOT NULL,
	QRCode NVARCHAR(max),
	BarCode NVARCHAR(max)
	
	FOREIGN KEY(IdUnit) REFERENCES dbo.Unit(Id),
	FOREIGN KEY(IdSuplier) REFERENCES dbo.Suplier(Id)
)
GO

CREATE TABLE UserRole
(
	Id INT IDENTITY(1,1) PRIMARY KEY,
	DisplayName NVARCHAR(max)
)
GO	

INSERT INTO dbo.UserRole(DisplayName) VALUES(N'Admin')
GO
INSERT INTO dbo.UserRole(DisplayName) VALUES(N'Nhân Viên')
GO

CREATE TABLE Users
(
	Id int IDENTITY(1,1) PRIMARY KEY,
	DisplayName NVARCHAR(max),
	UserName NVARCHAR(100),
	PassWord NVARCHAR(max),
	IdRole int NOT NULL

	FOREIGN KEY(IdRole) REFERENCES dbo.UserRole(Id)
)
GO

INSERT INTO dbo.Users(DisplayName, UserName, PassWord, IdRole) VALUES(N'LaQuocBuu', N'admin', N'cdd96d3cc73d1dbdaffa03cc6cd7339b', 1)
GO
INSERT INTO dbo.Users(DisplayName, UserName, PassWord, IdRole) VALUES(N'Nhân viên 1', N'staff01', N'cdd96d3cc73d1dbdaffa03cc6cd7339b', 1)
GO

CREATE TABLE Input
(
	Id NVARCHAR(128) PRIMARY KEY,
	DateInput DATETIME
)
GO

CREATE TABLE InputInfo
(
	Id NVARCHAR(128) PRIMARY KEY,
	IdObject NVARCHAR(128) NOT NULL,
	IdInput NVARCHAR(128) NOT NULL,
	Count INT,
	InputPrice FLOAT DEFAULT 0,
	OutputPrice FLOAT DEFAULT 0,
	Status NVARCHAR(max),

	FOREIGN KEY(IdObject) REFERENCES dbo.Object(Id),
	FOREIGN KEY(IdInput) REFERENCES dbo.Input(Id)
)

CREATE TABLE Output
(
	Id NVARCHAR(128) PRIMARY KEY,
	DateOutput DATETIME
)
GO

CREATE TABLE OutputInfo
(
	Id NVARCHAR(128) PRIMARY KEY,
	IdObject NVARCHAR(128) NOT NULL,
	IdInputInfo NVARCHAR(128) NOT NULL,
	IdCustomer INT NOT NULL,
	Count INT,
	Status NVARCHAR(max)

	FOREIGN KEY(IdObject) REFERENCES dbo.Object(Id),
	FOREIGN KEY(IdInputInfo) REFERENCES dbo.InputInfo(Id),
	FOREIGN KEY(IdCustomer) REFERENCES dbo.Customer(Id)
)
GO
