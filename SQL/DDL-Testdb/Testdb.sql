Create Database Testdb
use Testdb
create Table Customers
(
CustomerId int primary key,
CustomerName varchar(20),
Email varchar(20),
City varchar(10),
Age int
)

Drop table Customers

Create Table Orders
(
OrderId int primary key,
OrderDate datetime,
Amount int,
CustomerId int references Customers(CustomerId)
)

Drop Table Orders

----------------------

Create Table Products
(
ProductId int,
ProductName varchar(50),
Brand varchar(20),
Quantity int,
Price int
)
 
-- Adding new column in product table
Alter Table Products add ProductDescription varchar(50)

-- Removing colmn from product table

Alter Table Products drop column ProductDescription

-- Constraints
---check contraint to restrict the value of Quantity column

Alter Table Products add constraint check_quantity check(Quantity>0)

-- Adding primary key in existing product table 
Alter Table Products alter column ProductId int not null
Alter Table Products add constraint pk1 primary key(ProductId) 

-- Removing check constraints from product table

Alter Table Products drop constraint check_quantity


-------dropping foreign key from orders table
Alter Table Orders drop constraint FK__Orders__Customer__4E88ABD4

--Adding foreign key on orders table using alter statement

Alter Table Orders add constraint fk1 foreign key(CustomerId) references Customers(CustomerId) 


----
Create Table one
(
oneid int,
onetitle varchar(20)
)

---Adding primary key to existing one table
Alter Table one alter column oneid int not null
Alter Table one add constraint pkk primary key(oneid)