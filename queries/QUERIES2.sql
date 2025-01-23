create database Hardware_Shop;

use Hardware_Shop;


create table Users (
	UserId INT IDENTITY(1, 1)  NOT NULL,
	UserFirstName VARCHAR(50) NOT NULL,
	UserSecondName VARCHAR(50),
	UserContactNumber VARCHAR(50) NOT NULL,
	UserNIC VARCHAR(50) NOT NULL,
	UserName VARCHAR(50) NOT NULL,
	UserPassword VARCHAR(50) NOT NULL,
	Role VARCHAR(50) NOT NULL,
	CONSTRAINT User_Table_User_ID_PK PRIMARY KEY(UserID)
);

insert into Users(UserFirstName, UserSecondName, UserContactNumber, UserNIC, UserName, UserPassword, Role) VALUES
('Senesh', 'Divyanga', '0763616701', '200800401310', 'Sena', '1234', 'Admin');

insert into Users(UserFirstName, UserSecondName, UserContactNumber, UserNIC, UserName, UserPassword, Role) VALUES
('Piyum', 'Semal', '0775757173', '200719204712', 'Semalp119', '460353', 'Admin');

insert into Users(UserFirstName, UserSecondName, UserContactNumber, UserNIC, UserName, UserPassword, Role) VALUES
('Dineth', 'Tharusha', '0766947868', '200729301799', 'Dineth', '1234', 'Admin');

insert into Users(UserFirstName, UserSecondName, UserContactNumber, UserNIC, UserName, UserPassword, Role) VALUES
('Ruvindu', 'Kavinda', '0774805760', '200704621234', 'Ruviya', '1234', 'User');

insert into Users(UserFirstName, UserSecondName, UserContactNumber, UserNIC, UserName, UserPassword, Role) VALUES
('Haritha', 'Keshani', '0702843722', '200480803876', 'Kesh', '1234', 'User');

select * from users;

create table Inventory(
	InventoryID INT IDENTITY(1, 1),
	InventoryName VARCHAR(50) NOT NULL,
	InventoryType VARCHAR(50) NOT NULL,
	InventoryQuantity INT NOT NULL,
	SupplierName VARCHAR(50) NOT NULL,
	CONSTRAINT Inventory_Table_Inventory_ID_PK PRIMARY KEY(InventoryID)
);

drop table Inventory;


INSERT INTO Inventory(InventoryName, InventoryType, InventoryQuantity, SupplierName) VALUES
('RGB Fans', 'Computer Accesories', 10, 'Rashmi Akarsha');

INSERT INTO Inventory(InventoryName, InventoryType, InventoryQuantity, SupplierName) VALUES
('LEDD Monitor', 'Computer Accesories', 5, 'Dinethi Nethmika');

INSERT INTO Inventory(InventoryName, InventoryType, InventoryQuantity, SupplierName) VALUES
('Gaming Mouse', 'Computer Accesories', 15, 'Rashmi Akarsha');

select * from Inventory;

ALTER TABLE Inventory DROP CONSTRAINT InventoryID;

create table Sales(
	SaleID INT IDENTITY(1, 1),
	InventoryName VARCHAR(50) NOT NULL,
	InventoryType VARCHAR(50) NOT NULL,
	InventoryQuantity INT NOT NULL,
	CustomerName VARCHAR(50) NOT NULL,
	SaleDate DATE NOT NULL,
	CONSTRAINT Sales_Table_Sale_ID_PK PRIMARY KEY(SaleID),
);

drop table Sales;


INSERT INTO Sales(InventoryName, InventoryType, InventoryQuantity, CustomerName, SaleDate) VALUES
('RGB Fans', 'Computer Accesories', 2, 'Ruvindu Kavinda', '2021-09-01');

INSERT INTO Sales(InventoryName, InventoryType, InventoryQuantity, CustomerName, SaleDate) VALUES
('LEDD Monitor', 'Computer Accesories', 1, 'Senal Kavinda', '2021-09-02');


SELECT * FROM Sales;

create table Customers(
	CustomerID INT IDENTITY(1, 1),
	CustomerName VARCHAR(50) NOT NULL,
	CustomerContactNumber VARCHAR(50) NOT NULL,
	CustomerAddress VARCHAR(100) NOT NULL,
	CONSTRAINT Customers_Table_Customer_ID_PK PRIMARY KEY(CustomerID)
);

insert into Customers(CustomerName, CustomerContactNumber, CustomerAddress) VALUES
('Ruvindu Kavinda', '0774805760', 'No 12, Kandy Road, Kegalle');

insert into Customers(CustomerName, CustomerContactNumber, CustomerAddress) VALUES
('Senal Kavinda', '0774805760', 'No 12, Pure Road, Kegalle');

select * from Customers;

create table Suppliers(
	SupplierID INT IDENTITY(1, 1),
	SupplierName VARCHAR(50) NOT NULL,
	SupplierContactNumber VARCHAR(50) NOT NULL,
	CONSTRAINT Suppliers_Table_Supplier_ID_PK PRIMARY KEY(SupplierID)
);

insert into Suppliers(SupplierName, SupplierContactNumber) VALUES
('Rashmi Akarsha', '0774805760');

insert into Suppliers(SupplierName, SupplierContactNumber) VALUES
('Dinethi Nethmika', '0774805760');

select * from Suppliers;