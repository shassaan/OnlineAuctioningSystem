
CREATE TABLE Customer (
id INT PRIMARY KEY IDENTITY(1,1),
LicenseNo VARCHAR(100),
PANNo VARCHAR(10),
isApproved BIT,
isDeleted BIT
)

CREATE TABLE [User](
id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(100),
Email VARCHAR(100),
[Password] VARCHAR(300),
[userType] VARCHAR(100)
)


CREATE TABLE Complaint(
id INT PRIMARY KEY IDENTITY(1,1),
buyerId INT FOREIGN KEY REFERENCES dbo.Customer,
sellerId INT FOREIGN KEY REFERENCES dbo.[User],
[Description] VARCHAR(500),
[Subject] VARCHAR(200),
isDeleted BIT,
[Status] INT
)

CREATE TABLE Product(
id INT PRIMARY KEY IDENTITY(1,1),
Name VARCHAR(200),
[Description] VARCHAR(500),
displayPicture VARCHAR(100),
startData VARCHAR(100),
startPrice FLOAT,
endDate VARCHAR(100),
isDeleted BIT,
isSoldout BIT,
currentPrice FLOAT,
sellerId INT FOREIGN KEY REFERENCES dbo.[User]
)

CREATE TABLE ProductImage (
id INT PRIMARY KEY IDENTITY(1,1),
[image] VARCHAR(100),
productId INT FOREIGN KEY REFERENCES dbo.Product,
isDeleted BIT
)

CREATE TABLE Bid(
id INT PRIMARY KEY IDENTITY(1,1),
productId INT FOREIGN KEY REFERENCES dbo.Product,
bidPrice FLOAT,
customerId INT FOREIGN KEY REFERENCES dbo.Customer,
isDeleted BIT
)


