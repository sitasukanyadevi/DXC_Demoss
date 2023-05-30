Use Northwind

---DQL---8/5/2023

Select * from Customers

select * from Products

Select ContactName, CustomerId, Country, City, PostalCode from Customers

Select * from Customers where CustomerID='BOTTM'

Select * from Customers where City='Lule?'

Select CustomerId, City from Customers where ContactTitle='Sales Representative'

Select * from Products where ReorderLevel>10

Select * from Customers

Select * from Customers where City='Berlin' or City='Tsawassen'

Select * from Customers where  City='London' and Country='Canada'

Select * from Customers where Country='UK' and City='London'

Select * from Customers where Fax is not null

Select * from Customers where Fax is null

Select * from Customers where not Fax is null

Select * from Customers where Region is null

Select * from Customers where not City='UK'

select * from Products

Select ProductID, ProductName, QuantityPerUnit, UnitPrice, UnitsInStock, UnitPrice*UnitsInStock as Amount, (UnitPrice*UnitsInStock)*10/100
as Discount from Products

Select * from Products where SupplierID not between 7 and 20

Select * from Customers where City='London' or City='Madrid' or City='Paris' or City='Berlin'

Select * from Customers where City in ('London', 'Madrid', 'Paris', 'Berlin')

Select * from Customers

Select * from Customers where ContactName like 'Ha%'

Select * from Customers where ContactName like 'S_____________'

Select * from Customers where ContactName like '[^NO]%'

Select * from Customers where ContactName like 'A%O'

Select top 20 * from Customers

Select * from Customers Order By ContactName 

Select * from Customers

Select * from Customers Order By CustomerID offset 20 rows fetch next 15 rows only

Select distinct ContactTitle from Customers

----------------------9/5/23

Select * from Products

--Aggregate functions

Select SUM(UnitPrice) from Products

Select AVG(UnitPrice) from Products

Select MAX(UnitPrice) from Products

Select MIN(UnitPrice) from Products

--string functions

Select CHAR(65)

Select CHAR(92)

Select LEFT('HELLOWORLD',5)

Select RIGHT('HELLOWORLD',5)

Select LEN('HELLOWORLD')

Select REVERSE('HELLOWORLD')

select * from Customers

Select LEFT(CompanyName,5) from Customers

Select RIGHT(CompanyName,5) from Customers

Select REVERSE(CompanyName) from Customers

Select CompanyName, LEN(CompanyName) as Length from Customers


------DAte functions

Select GETDATE()

Select DATEADD(yyyy,5,'2023-05-09') --yyyy-mm-dd

Select DATEADD(mm,5,'2023-05-09')

Select DATEADD(dd,5,'2023-05-09')

Select OrderDate,DATEADD(dd,5,OrderDate) as DeliveryDate from Orders

Select DATEDIFF(mm, '2023-01-09', '2023-05-09')

Select DATEDIFF(dd, '2022-01-09', '2023-01-20')

Select DATEDIFF(yyyy, '2022-01-09', '2025-01-09')

-------Math functions

select POWER(5,4)

select SQRT(25)

select square(5)

select ROUND(3.56789,0)

select ROUND(3.56789,1)

select ROUND(3.56789,2)

select ROUND(3.56789,3)

select ROUND(3.56789,4)

Select CEILING(4.2)

Select FLOOR(4.9)


-- Group By Clause

select * from Products

select SupplierID , SUM(UnitsOnOrder) as TotalOrder from Products group by SupplierID

select SupplierID , SUM(UnitsOnOrder) as TotalOrder from Products group by SupplierID having SupplierID between 7 and 15


-- Joins

--inner joins

select * from Customers

select * from Orders 

select Customers.CustomerID ContactName, ContactTitle, Address, Phone, Country, OrderId, OrderDate, ShippedDate, ShipName from Customers inner join Orders on Customers.CustomerID=Orders.CustomerID

-- Left Outer Join
Select Customers.CustomerID, ContactName, ContactTitle, Address, Phone, Country, OrderId, OrderDate, ShippedDate, ShipName from Customers left outer join Orders on 
Customers.CustomerID=Orders.CustomerID

-- Right Outer Join
Select Customers.CustomerID, ContactName, ContactTitle, Address, Phone, Country, OrderId, OrderDate, ShippedDate, ShipName from Customers right outer join Orders on 
Customers.CustomerID=Orders.CustomerID

-- Full Outer Join
Select Customers.CustomerID, ContactName, ContactTitle, Address, Phone, Country, OrderId, OrderDate, ShippedDate, ShipName from Customers full outer join Orders on 
Customers.CustomerID=Orders.CustomerID

----
CREATE TABLE Emp(
EmpId varchar(20),
EmpName varchar(20),
MgrId varchar(20)
)

Insert into Emp values ('EOO1','John','MOO2'),('EOO2','James','MOO3'),('EOO3','Steve','MOO1')

select * from Emp

Insert into Emp(EmpId,EmpName) values ('MOO1','Peter'),('MOO2','Maria'),('MOO3','Bob')

select * from Emp
----
--self join
Select * from Emp
Select Emp.EmpName, Emp2.EmpName as ReportsTo from Emp inner join Emp as Emp2 on Emp.MgrId = Emp2.EmpId


-- Subqueries

Select * from Students

Select StudentName from Students where Marks = (Select Max(Marks) from Students)

Select * from Students where Marks = (Select Max(Marks) from Students where Marks<(Select MAX(Marks) from Students))

Select * from Students order by Marks Desc

Select * from Students order by Marks Desc offset 3 rows fetch next 1 rows only

-- Creating Views

Create View ProductDetailsView
as
Select ProductId, ProductName, UnitPrice, UnitsInStock, UnitPrice*UnitsInStock as Amount, (UnitPrice*UnitsInStock)*10/100 as Discount from Products

Select * from ProductDetailsView

-- Creating Functions (UDF - User Defined Function)

Create Function Cube(@num int)
returns int
as
begin
	RETURN POWER(@num, 3)
end

Select dbo.Cube(5)

-- Table Valued Function (Inline)

Create Function GetCustomer(@city varchar(10))
returns table
as
return (Select * from Customers where City=@city)

Select * from GetCustomer('Paris')

-- Stored Procedures

Create Proc ShowCustomers
as
Select * from Customers

Exec ShowCustomers

Create Procedure SearchCustomerr
@customerid varchar(5)
as
Select * from Customers where CustomerID=@customerid

Exec SearchCustomerr 'BERGS'


-----
CREATE TABLE Students(
RollNo int,
StudentName varchar(20),
Marks int
)

Insert into Students values (1,'Neha',90),(2,'Sahil',50),(3,'Rohan',70),(4,'Ankita',80),(5,'Rahul',65),(6,'Swati',55), (7,'Alka',75)


Select * from Students

Create Proc AddNewStudent
@rollno int,
@name varchar(10),
@marks int
as 
insert into Students values(@rollno,@name,@marks)

update Students set RollNo=8 from Students where StudentName='Mohan'

Exec AddNewStudent 11,'Mohan',82

Select * from Students

Alter Proc AddNewStudent
@rollno int,
@name varchar(10),
@marks int
as
begin
if(@marks>100)
begin
	print 'Marks cannot be greater than 100'
	rollback tran
end
else
	begin
		insert into Students values(@rollno, @name, @marks)
	end
end

Exec AddNewStudent 9, 'Jessabel', 98

Select * from Students

