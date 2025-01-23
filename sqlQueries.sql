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

select * from users;s

create table Inventory(
	InventoryID INT IDENTITY(1, 1),
	InventoryName VARCHAR(50) NOT NULL,
	InventoryType VARCHAR(50) NOT NULL,
	InventoryQuantity INT NOT NULL,
	CONSTRAINT Inventory_Table_Inventory_ID_PK PRIMARY KEY(InventoryID)
);

insert into Inventory(InventoryName, InventoryType, InventoryQuantity) VALUES
('RGB Fans', 'Computer Accesories', 10);

insert into Inventory(InventoryName, InventoryType, InventoryQuantity) VALUES
('LEDD Monitor', 'Computer Accesories', 8);

insert into Inventory(InventoryName, InventoryType, InventoryQuantity) VALUES
('Fantech KeyBoard', 'Computer Accesories', 20);

select * from Inventory;




