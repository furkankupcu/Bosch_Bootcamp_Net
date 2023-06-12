CREATE DATABASE Bosch_Bootcamp
GO
USE Bosch_Bootcamp
GO 
CREATE TABLE BB_Area ( 
 AreaID CHAR(1) PRIMARY KEY,
 AreaName CHAR(15) UNIQUE NOT NULL--F,R
)
GO
CREATE TABLE BB_Department (
 DepartmentID INT PRIMARY KEY,
 DepartmentName CHAR(3) UNIQUE NOT NULL, --MD1
 AreaID CHAR(1) FOREIGN KEY REFERENCES BB_Area(AreaID) NOT NULL,
 DepartmentBudget DECIMAL(19, 4) DEFAULT 0
)
GO
CREATE TABLE BB_Models(
 ModelNumber CHAR(3) PRIMARY KEY, --model_numarasý: B1,B2,D1…
 ModelName CHAR(10) UNIQUE NOT NULL,  --Benzinli 1,Benzinli 2,Dizel 1
)
GO
CREATE TABLE BB_Order (
 OrderID INT PRIMARY KEY,
 OrderStatus CHAR(15) NOT NULL,
 OrderDate SMALLDATETIME,
)
GO
CREATE TABLE BB_OrderDetail(
 OrderID INT FOREIGN KEY REFERENCES BB_Order(OrderID),
 ModelNumber CHAR(3) FOREIGN KEY REFERENCES BB_Models(ModelNumber) NOT NULL ,
 OrderQuantity INT NOT NULL
)
GO
CREATE TABLE BB_Injector(
 Injector_ID INT PRIMARY KEY, 
 ModelNumber CHAR(3) FOREIGN KEY REFERENCES BB_Models(ModelNumber) NOT NULL, 
 InjectorPrice DECIMAL(19, 4) DEFAULT 0,
 InjectorStatus CHAR(20) NOT NULL,
 OrderID INT FOREIGN KEY REFERENCES BB_Order(OrderID) NOT NULL
)
GO
CREATE TABLE BB_Section (
 SectionID INT PRIMARY KEY, 
 SectionName CHAR(6) UNIQUE NOT NULL,
 DepartmentID INT FOREIGN KEY REFERENCES BB_Department(DepartmentID) NOT NULL,
 ModelNumber CHAR(3) FOREIGN KEY REFERENCES BB_Models(ModelNumber) UNIQUE
)
GO
CREATE TABLE BB_Station(
	StationID INT PRIMARY KEY,
)
GO
CREATE TABLE BB_SubcomponentType(
	SubcomponentType INT PRIMARY KEY,
	StationID INT FOREIGN KEY REFERENCES BB_Station(StationID) NOT NULL,
	SubcomponentCost DECIMAL(19, 4) NOT NULL
)
GO 
CREATE TABLE BB_Subcomponent(
	SubcomponentID INT PRIMARY KEY,
	SubcomponentType INT FOREIGN KEY REFERENCES  BB_SubcomponentType(SubcomponentType) NOT NULL,
)
GO 
CREATE TABLE BB_StationProcess( --Hangi istasyonda,ne zaman, hangi enjektöre, hangi alt parça eklenmiþ? 
	StationID INT FOREIGN KEY REFERENCES BB_Station(StationID) NOT NULL,
    InjectorID INT FOREIGN KEY REFERENCES BB_Injector(Injector_ID) NOT NULL,
	SubcomponentID INT REFERENCES BB_Subcomponent(SubcomponentID) NOT NULL,
	ProcessTime SMALLDATETIME NOT NULL,
	ProcessStatus INT NOT NULL, --0 :iyi , 1: kötü
)




