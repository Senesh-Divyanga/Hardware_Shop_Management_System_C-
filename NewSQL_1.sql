create database Hardware_Shop;

use Hardware_Shop;


CREATE TABLE Users (
    UserId INT IDENTITY(1, 1) NOT NULL,
    UserFirstName VARCHAR(50) NOT NULL,
    UserSecondName VARCHAR(50),
    UserContactNumber VARCHAR(50) NOT NULL,
    UserNIC VARCHAR(50) NOT NULL,
    UserName VARCHAR(50) NOT NULL,
    UserPassword VARCHAR(50) NOT NULL,
    Role VARCHAR(50) NOT NULL,
    CONSTRAINT User_Table_User_ID_PK PRIMARY KEY(UserID)
);

INSERT INTO Users (UserFirstName, UserSecondName, UserContactNumber, UserNIC, UserName, UserPassword, Role)
VALUES ('Senesh', 'Divyanga', '0763616701', '200800401310', 'Sena', '1234', 'Admin');

INSERT INTO Users (UserFirstName, UserSecondName, UserContactNumber, UserNIC, UserName, UserPassword, Role)
VALUES ('Piyum', 'Semal', '0775757173', '200719204712', 'Semalp119', '460353', 'User');

select * from Users;


DROP TABLE Users;


CREATE TABLE Inventory (
    InventoryID INT IDENTITY(1, 1) NOT NULL,
    InventoryName VARCHAR(50) NOT NULL,
    InventoryType VARCHAR(50) NOT NULL,
    InventoryQuantity INT NOT NULL,
    UnitPrice INT,
    SupplierID INT NOT NULL,
    CONSTRAINT Inventory_Table_Inventory_ID_PK PRIMARY KEY (InventoryID),
    CONSTRAINT FK_Inventory_Suppliers FOREIGN KEY (SupplierID) REFERENCES Suppliers(SupplierID)
);





drop table Inventory;


INSERT INTO Inventory (InventoryName, InventoryType, InventoryQuantity, UnitPrice, SupplierID)
VALUES 
('Graphics Card', 'Hardware', 50, 75000, 1),
('Motherboard', 'Hardware', 30, 25000, 1),
('Processor', 'Hardware', 40, 50000, 2),
('RAM', 'Hardware', 100, 15000, 2),
('SSD', 'Storage', 80, 20000, 3),
('HDD', 'Storage', 70, 12000, 3),
('Power Supply Unit', 'Hardware', 60, 8000, 4),
('Monitor', 'Peripheral', 45, 30000, 4),
('Keyboard', 'Peripheral', 120, 5000, 5),
('Mouse', 'Peripheral', 150, 4000, 5);


select * from Inventory;


DROP TABLE Inventory;

CREATE TABLE Sales (
    SaleID INT IDENTITY(1, 1) NOT NULL,
    InventoryID INT NOT NULL,
    InventoryName VARCHAR(50) NOT NULL,
    CustomerID INT NOT NULL,
    InventoryQuantity INT NOT NULL,
    SaleDate DATE NOT NULL,
    Total DECIMAL(10, 2) NOT NULL,
    CONSTRAINT Sales_Table_Sale_ID_PK PRIMARY KEY (SaleID),
    CONSTRAINT FK_Sales_Inventory FOREIGN KEY (InventoryID) REFERENCES Inventory(InventoryID)
);

DROP TABLE Sales;


ALTER TABLE Sales
DROP CONSTRAINT FK_Sales_Customers;




ALTER TABLE Sales
DROP CONSTRAINT FK_Sales_Inventory;

ALTER TABLE Sales
DROP COLUMN InventoryID;

select * from Sales;


DROP TABLE Sales;

CREATE TABLE Customers (
    CustomerID INT IDENTITY(1, 1) NOT NULL,
    CustomerName VARCHAR(50) NOT NULL,
    CustomerContactNumber VARCHAR(50) NOT NULL,
    CONSTRAINT Customers_Table_Customer_ID_PK PRIMARY KEY(CustomerID)
);

insert into Customers (CustomerName, CustomerContactNumber) VALUES ('Senal Kavinda', '0763616701');

select * from Customers;

DROP TABLE Customers;

CREATE TABLE Suppliers (
    SupplierID INT IDENTITY(1, 1) NOT NULL,
    SupplierName VARCHAR(50) NOT NULL,
    SupplierContactNumber VARCHAR(50) NOT NULL,
    CONSTRAINT Suppliers_Table_Supplier_ID_PK PRIMARY KEY(SupplierID)
);


INSERT INTO Suppliers (SupplierName, SupplierContactNumber)
VALUES 
('Binary TechZone', '0771234567'),
('Ash Computers', '0777654321'),
('AKD Suppliers', '0712345678'),
('RedTech', '0718765432'),
('QWE Zone', '0773456789');


select * from Suppliers;

DROP TABLE Suppliers;

